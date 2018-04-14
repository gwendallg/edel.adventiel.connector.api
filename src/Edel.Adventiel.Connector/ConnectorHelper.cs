using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Autumn.Mvc.Data.Configurations;
using Edel.Adventiel.Connector.Entities;
using MongoDB.Driver;
using System.Linq;
using System.Reflection;
using Autumn.Mvc.Data.MongoDB.Annotations;
using Edel.Adventiel.Connector.Entities.Cattles.Breeding;
using Edel.Adventiel.Connector.Entities.References;
using Edel.Adventiel.Connector.Services;
using Newtonsoft.Json;

namespace Edel.Adventiel.Connector
{
    public static class ConnectorHelper
    {
        public static void Initialize(AutumnDataSettings dataSettings, IMongoDatabase database)
        {
            TryAddAdminIfNotExistUsers(dataSettings, database);
            TryAddResourceIfNotExist<Site>(database);
            TryAddResourceIfNotExist<Department>(database);
            TryAddResourceIfNotExist<CalvingCondition>(database);
        }

        private static void TryAddAdminIfNotExistUsers(AutumnDataSettings dataSettings, IMongoDatabase database)
        {

            var userService = new UserService(dataSettings, database, null);

            var collection = database.GetCollection<User>("user");
            var count = collection.Count(u => true);
            if (count != 0) return;

            var user = new User
            {
                Username = "admin",
                Claims = new Dictionary<string, string>()
            };
            foreach (var info in dataSettings.EntitiesInfos.Values)
            {
                var claimKey = string.Format("{0}_{1}", info.ApiVersion, info.Name);
                var stringBuilder = new StringBuilder();
                stringBuilder.Append(ScopeType.Read.ToString() + ',');
                if (!info.IgnoreOperations.Contains(HttpMethod.Post))
                    stringBuilder.Append(ScopeType.Create.ToString() + ',');
                if (!info.IgnoreOperations.Contains(HttpMethod.Put))
                    stringBuilder.Append(ScopeType.Update.ToString() + ',');
                if (!info.IgnoreOperations.Contains(HttpMethod.Delete))
                    stringBuilder.Append(ScopeType.Delete.ToString() + ',');
                var claimValue = stringBuilder.ToString().Trim().TrimEnd(',');
                user.Claims.Add(claimKey, claimValue);
            }

            user.Claims.Add("v1_user", $"{ScopeType.Read}, {ScopeType.Create}, {ScopeType.Update}, {ScopeType.Delete}");
            user.Claims.Add("v1_subscription",$"{ScopeType.Read}, {ScopeType.Create}, {ScopeType.Update}, {ScopeType.Delete}");
            var task = userService.AddAsync(user, "admin");
            task.Wait();
        }

        private static string Json(string resourceFileName)
        {
            using (var stream =
                typeof(ConnectorHelper).Assembly.GetManifestResourceStream(
                    typeof(ConnectorHelper).Namespace + ".Resources." + resourceFileName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static void TryAddResourceIfNotExist<T>(IMongoDatabase database) where T:IEntity
        {
            var collectionAttribute = (CollectionAttribute) typeof(T).GetCustomAttribute(typeof(CollectionAttribute));
            var collection = database.GetCollection<T>(collectionAttribute.Name);
            var count = collection.Count(u => true);
            if (count != 0) return;

            var items = JsonConvert.DeserializeObject<List<T>>(Json(typeof(T).Name+"s.json"));
            items.ForEach(it => it.Metadata = new Metadata() {CreatedAt = "admin", CreatedDate = DateTime.UtcNow});
            var task = collection.InsertManyAsync(items);
            task.Wait();
        }
      
        
    }
}