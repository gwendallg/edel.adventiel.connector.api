using System;
using System.Collections.Generic;
using Microsoft.Extensions.HealthChecks;
using MongoDB.Driver;

namespace Edel.Connector.HealthChecks
{
    public static class HealthCheckBuilderExtension
    {

        private static readonly TimeSpan DefaulCacheDuration = new TimeSpan(0, 0, 1);

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
            string bootstrapServers, string topic, TimeSpan? cacheDuration = null)
        {
            healthCheckBuilder.AddCheck("Kafka",
                new KafkaCheck(bootstrapServers, topic),
                cacheDuration.HasValue ? cacheDuration.Value : DefaulCacheDuration);
            return healthCheckBuilder;
        }

    }
}