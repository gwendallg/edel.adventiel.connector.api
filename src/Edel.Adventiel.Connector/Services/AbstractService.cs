using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public class AbstractService
    {
        private readonly IMongoDatabase _database;
        
        protected IMongoDatabase Database()
        {
            return _database;
        }

        protected AbstractService(IMongoDatabase database)
        {
            _database = database;
        }

    }
}