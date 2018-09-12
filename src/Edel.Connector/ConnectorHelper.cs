using System;
using System.Collections.Generic;
using System.IO;
using MongoDB.Driver;
using System.Reflection;
using Autumn.Mvc.Data.MongoDB.Annotations;
using Edel.Connector.Models;
using Edel.Connector.Models.Bovines.Breeding;
using Edel.Connector.Models.References;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Edel.Connector
{
    public static class ConnectorHelper
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            var scope = applicationBuilder.ApplicationServices.CreateScope();
            var database = (IMongoDatabase) scope.ServiceProvider.GetService(typeof(IMongoDatabase));
            var userService = (IUserService) scope.ServiceProvider.GetService(typeof(IUserService));
          
            TryAddAdminIfNotExistUsers(userService);
            TryAddResourceIfNotExist<Site>(database);
            TryAddResourceIfNotExist<Department>(database);
            TryAddResourceIfNotExist<BovineCalvingCondition>(database);
        }
       

        private static void TryAddAdminIfNotExistUsers(IUserService userService)
        {
            var task = userService.TryAddAdminIfNotExistUsersAsync();
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

        private static void TryAddResourceIfNotExist<T>(IMongoDatabase database) where T : IEntity
        {
            var collectionAttribute = (CollectionAttribute) typeof(T).GetCustomAttribute(typeof(CollectionAttribute));
            var collection = database.GetCollection<T>(collectionAttribute.Name);
            var count = collection.CountDocuments(u => true);
            if (count != 0) return;

            var items = JsonConvert.DeserializeObject<List<T>>(Json(typeof(T).Name + "s.json"));
            items.ForEach(it => it.Metadata = new Metadata() {CreatedAt = "admin", CreatedDate = DateTime.UtcNow});
            var task = collection.InsertManyAsync(items);
            task.Wait();
        }
    }
}