using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Extensions.HealthChecks;
using MongoDB.Driver;

namespace Edel.Connector.HealthChecks
{
    public static class HealthCheckBuilderExtension
    {
        
        private static readonly TimeSpan DefaulCacheDuration = new TimeSpan(0,0,1);

        public static HealthCheckBuilder AddMongoCheck(this HealthCheckBuilder healthCheckBuilder,
            string connectionString, string database, IEnumerable<string> collections,
            MongoDatabaseSettings databaseSettings = null, TimeSpan? cacheDuration = null)
        {
            healthCheckBuilder.AddCheck("Mongo",
                new MongoCheck(connectionString, database, collections, databaseSettings),
                cacheDuration.HasValue ? cacheDuration.Value : DefaulCacheDuration);
            return healthCheckBuilder;
        }

        public static HealthCheckBuilder AddKafkaCheck(this HealthCheckBuilder healthCheckBuilder,
            string bootstrapServers, TimeSpan? cacheDuration = null)
        {


            healthCheckBuilder.AddCheck("Kafka",
                new KafkaCheck(bootstrapServers, BuildClientId()),
                cacheDuration.HasValue ? cacheDuration.Value : DefaulCacheDuration);
            return healthCheckBuilder;
        }

        private static  string BuildClientId()
        {
            var hostName = Dns.GetHostName();
            var ips = Dns.GetHostEntry(hostName)
                .AddressList
                .Select(a => a.ToString() + ",")
                .Aggregate(string.Concat).TrimEnd(',');

            return $"{hostName} ({ips})";
        }
    }
}