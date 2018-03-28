using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Configurations;
using Edel.Adventiel.Connector.Api.Entities;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Api.Services
{
    public class UserService : AbstractService<User>, IUserService
    {
        private readonly AutumnDataSettings _dataSettings;
        private const string CScopeRead = "read";
        private const string CScopeCreate = "create";
        private const string CScopeUpdate = "update";
        private const string CScopeDelete = "delete";

        public UserService(AutumnDataSettings dataSettings, IMongoDatabase database) : base(database, "user")
        {
            _dataSettings = dataSettings;
        }

        public async Task<User> AddAsync(User user, string password, HttpContext context)
        {
            user.Salt = GetRandomSalt();
            user.Hash = GetHash(password, user.Salt);
            CheckClaims(user);
            user.Metadata.CreatedAt = context.User.Identity.Name;
            user.Metadata.CreatedDate = DateTime.UtcNow;
            await Collection().InsertOneAsync(user);
            return user;
        }

        private Dictionary<string, Type> GetEntityTypeByRoute()
        {
            var result = _dataSettings
                .Routes
                .ToDictionary(x => x.Value.Template.TrimStart('/').Replace('/', '_'), x => x.Key);
            result.Add("v1_user", typeof(User));
            return result;
        }

        public Dictionary<Type, IList<string>> GetClaimsByEntityType()
        {
            var result = new Dictionary<Type, IList<string>>();
            foreach (var item in _dataSettings.EntitiesInfos)
            {
                var claims = new List<string>();
                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Post))
                {
                    claims.Add(CScopeCreate);
                }

                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Put))
                {
                    claims.Add(CScopeUpdate);
                }

                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Delete))
                {
                    claims.Add(CScopeDelete);
                }

                result.Add(item.Key, claims);
            }
      
            // add no entity
            result.Add(typeof(User),new List<string>(){CScopeRead,CScopeCreate,CScopeUpdate,CScopeDelete});
            return result;
        }


        private void CheckClaims(User user)
        {
            var claimsByEntity = GetClaimsByEntityType();
            var entityTypeByRoute = GetEntityTypeByRoute();

            foreach (var claim in user.Claims)
            {
                if (!entityTypeByRoute.ContainsKey(claim.Key))
                {
                    throw new Exception(string.Format("Claims {0} not exist",claim.Key));
                }

                var resourceType = entityTypeByRoute[claim.Key];
                var claimRessource = claimsByEntity[resourceType];
            }
        }

        public async Task<User> FindByUserNameAsync(string userName)
        {
            return await Collection()
                .Find(u => u.Username == userName)
                .SingleOrDefaultAsync();
        }

        public async Task<User> UpdateAsync(User user, string password, HttpContext context)
        {

            var userDb = await Collection()
                .Find(u => u.Username == user.Username)
                .SingleOrDefaultAsync();

            if (userDb == null) throw new Exception("User not found");
            userDb.Salt = GetRandomSalt();
            userDb.Hash = GetHash(password, userDb.Salt);
            userDb.Claims = user.Claims;
            CheckClaims(userDb);

            await Collection().ReplaceOneAsync(u => u.Username == userDb.Username, userDb);
            return userDb;
        }

        public async Task<User> Authenticate(string userName, string password)
        {
            var user = await FindByUserNameAsync(userName);
            if (user == null) return null;
            if (GetHash(password, user.Salt) != user.Hash) return null;
            return user;
        }

        static string GetHash(string password, string salt)
        {
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentNullException(nameof(password));
            if (string.IsNullOrWhiteSpace(salt)) throw new ArgumentNullException(nameof(salt));
            var text = string.Concat(password, salt);
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
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
    }
}