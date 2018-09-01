using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Repositories;
using Edel.Connector.Models;
using Microsoft.AspNetCore.Http;

namespace Edel.Connector.Services
{
    public class UserService :  AbstractService, IUserService
    {
        private readonly IClaimsService _claimsService;
        private readonly ICrudPageableRepositoryAsync<User, string> _userRepository;
        private readonly ICrudPageableRepositoryAsync<RefreshToken, string> _refreshTokenRepository;

        public UserService(
            IHttpContextAccessor contextAccessor, IClaimsService claimsService,
            ICrudPageableRepositoryAsync<User, string> userRepository,
            ICrudPageableRepositoryAsync<RefreshToken,string> refreshTokenRepository) : base(contextAccessor)
        {
            _claimsService = claimsService;
            _userRepository = userRepository;
            _refreshTokenRepository = refreshTokenRepository;
        }

        public async Task<User> AddAsync(User user, string password)
        {
            user.Salt = GetRandomSalt();
            user.Hash = GetHash(password, user.Salt);
            ValidateClaims(user);
            user.Metadata = new Metadata
            {
                CreatedAt = Context()?.User?.Identity?.Name,
                CreatedDate = DateTime.UtcNow
            };
            return await _userRepository.InsertAsync(user);
        }

        private void ValidateClaims(User user)
        {
            if(user ==null ) throw new ArgumentNullException(nameof(user));
            if (user.Claims == null) return;
            var claims = new Dictionary<string, string>();
            
            foreach (var item in user.Claims)
            {
                var scopes = _claimsService.Parse(item.Key, item.Value);
                claims.Add(item.Key, _claimsService.ToString(scopes));
            }

            user.Claims = claims;
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
            ValidateClaims(userDb);
            return await _userRepository.UpdateAsync(user, user.Username);
        }

        /// <inheritdoc />
        public async Task<User> Authenticate(string userName, string password)
        {
            var user = await FindByUserNameAsync(userName);
            if (user == null) return null;
            var expected = GetHash(password, user.Salt);
            return expected != user.Hash ? null : user;
        }

        public async Task<User> Authenticate(string refreshToken)
        {
            var token = await _refreshTokenRepository.FindOneAsync(refreshToken);
            if (token == null) return null;
            await _refreshTokenRepository.DeleteAsync(refreshToken);
            if (token.ExpirationDate < DateTime.UtcNow) return null;
            return await FindByUserNameAsync(token.UserName);
        }

        public async Task<RefreshToken> CreateRefreshTokenAsync(User user, int duration = 120)
        {
            var result = new RefreshToken()
            {
                Id = Guid.NewGuid().ToString().Replace("-",""),
                UserName = user.Username,
                ExpirationDate = DateTime.UtcNow.AddMinutes(duration)
            };

            return await _refreshTokenRepository.InsertAsync(result);
        }

        private static string GetHash(string password, string salt)
        {
            var sha512 = SHA512.Create();
            var bytes = Encoding.UTF8.GetBytes(string.Concat(password,salt));
            var hash = sha512.ComputeHash(bytes);
            var result = new StringBuilder();
            foreach (var t in hash)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }

        private static string GetRandomSalt()
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
            foreach (var info in _claimsService.GetClaimsByResourcePaths())
            {
                user.Claims.Add(info.Key,_claimsService.ToString(info.Value));
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