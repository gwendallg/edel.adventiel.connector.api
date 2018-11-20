using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.HealthChecks;
using MongoDB.Driver;

namespace Edel.Connector.Api.HealthChecks
{
    public class MongoCheck : IHealthCheck
    {
        private readonly string _connectionString;
        private readonly string _databaseName;
        private readonly MongoDatabaseSettings _databaseSettings;
        private readonly IEnumerable<string> _collections;

        public MongoCheck(string connectionString, string databaseName, IEnumerable<string> collections,
            MongoDatabaseSettings databaseSettings = null)
        {
            _connectionString = connectionString;
            _databaseName = databaseName;
            _databaseSettings = databaseSettings;
            _collections = collections;
        }

        public async ValueTask<IHealthCheckResult> CheckAsync(
            CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                var client = new MongoClient(_connectionString);
                var database = client.GetDatabase(_databaseName, _databaseSettings);
                var result = await database.ListCollectionsAsync(cancellationToken: cancellationToken);
                if (!(_collections?.Count() > 0))
                    return HealthCheckResult.Healthy($"Successfully found all collection(s) on Mongo database");
                var collections = await result.ToListAsync(cancellationToken: cancellationToken);
                var names = collections.Select(b => b.GetValue("name").AsString).ToArray();
                foreach (var collection in _collections)
                {
                    if (!names.Contains(collection))
                    {
                        return HealthCheckResult.Unhealthy($"Failed to connect to Mongo Database, collection : {collection} not found");
                    }
                }

                return HealthCheckResult.Healthy($"Successfully found all collection(s) on Mongo database");
            }
            catch
            {
                return HealthCheckResult.Unhealthy($"Failed to connect to Mongo Database.");
            }
        }
    }
}