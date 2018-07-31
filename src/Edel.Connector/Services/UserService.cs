using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Configurations;
using Autumn.Mvc.Data.Repositories;
using Edel.Connector.Entities;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Connector.Services
{
    public class UserService :  AbstractService, IUserService
    {
        private readonly AutumnDataSettings _dataSettings;
        private readonly IClaimsService _claimsService;
        private readonly ICrudPageableRepositoryAsync<User, string> _userRepository;

        public UserService(AutumnDataSettings dataSettings, IMongoDatabase database,
            IHttpContextAccessor contextAccessor, IClaimsService claimsService,
            ICrudPageableRepositoryAsync<User, string> userRepository) : base(contextAccessor)
        {
            _dataSettings = dataSettings;
            _claimsService = claimsService;
            _userRepository = userRepository;
        }

        public async Task<User> AddAsync(User user, string password)
        {
            user.Salt = GetRandomSalt();
            user.Hash = GetHash(password, user.Salt);
            CheckClaims(user);
            user.Metadata = new Metadata
            {
                CreatedAt = Context()?.User?.Identity?.Name,
                CreatedDate = DateTime.UtcNow
            };
            return await _userRepository.InsertAsync(user);
        }

        private Dictionary<string, Type> GetEntityTypeByRoute()
        {
            
            var result = _dataSettings
                .Routes
                .ToDictionary(x => x.Value.Template.TrimStart('/').Replace('/', '_'), x => x.Key.GetGenericArguments()[0]);
            result.Add("v1_user", typeof(User));
            result.Add("v1_subscription",typeof(Subscription));
            return result;
        }

        private void CheckClaims(User user)
        {
            var claimsByEntity = _claimsService.GetClaimsByEntityType();
            var entityTypeByRoute = GetEntityTypeByRoute();
            foreach (var claim in user.Claims)
            {
                if (!entityTypeByRoute.ContainsKey(claim.Key))
                {
                    throw new Exception(string.Format("Claims {0} not exist", claim.Key));
                }

                if (_claimsService.TryParse(claim.Value, out var scopes))
                {
                   // TODO  check claims    
                }
                else
                {
                    throw new Exception(string.Format("Scopes {0} not exist for Claim {1}", claim.Value, claim.Key));
                }
            }
        }



        public async Task<User> FindByUserNameAsync(string userName)
        {
            var result = await _userRepository.FindAsync(u => u.Username == userName);
            return result.TotalElements == 1L ? result.Content[0] : null;
        }

        public async Task<User> UpdateAsync(User user, string password)
        {

            var userDb = await FindByUserNameAsync(user.Username);
            if (userDb == null) throw new Exception("User not found");
            userDb.Salt = GetRandomSalt();
            userDb.Hash = GetHash(password, userDb.Salt);
            userDb.Claims = user.Claims;
            user.Metadata.LastModifiedDate = DateTime.UtcNow;
            userDb.Metadata.LastModifiedAt = Context()?.User?.Identity?.Name;
            CheckClaims(userDb);
            return await _userRepository.UpdateAsync(user, user.Username);
        }

        /// <summary>
        /// authenticate user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<User> Authenticate(string userName, string password)
        {
            var user = await FindByUserNameAsync(userName);
            if (user == null) return null;
            var expected = GetHash(password, user.Salt);
            if (expected != user.Hash) return null;
            return user;
        }

        static string GetHash(string password, string salt)
        {
            var sha512 = SHA512Managed.Create();
            var bytes = Encoding.UTF8.GetBytes(string.Concat(password,salt));
            var hash = sha512.ComputeHash(bytes);
            var result = new StringBuilder();
            foreach (var t in hash)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }

        static string GetRandomSalt()
        {
            var bytes = new byte[128 / 8];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public async Task TryAddAdminIfNotExistUsersAsync(string adminPassword = "admin")
        {
            var result = await _userRepository.FindAsync(u => u.Username == "admin");
            if (result.HasContent) return;
            var user = new User() {Claims = new Dictionary<string, string>()};
            foreach (var info in _claimsService.GetClaimsByResources())
            {
                var stringBuilder = new StringBuilder();
                foreach (var item in info.Value)
                {
                    stringBuilder.Append(item + ",");
                }

                var claimValue = stringBuilder.ToString().Trim().TrimEnd(',');
                user.Claims.Add(info.Key, claimValue);

            }

            user.Username = "admin";
            user.Salt = GetRandomSalt();
            user.Hash = GetHash(adminPassword, user.Salt);
            user.Metadata = new Metadata
            {
                CreatedAt = "admin",
                CreatedDate = DateTime.UtcNow
            };

            await _userRepository.InsertAsync(user);
        }
    }
}