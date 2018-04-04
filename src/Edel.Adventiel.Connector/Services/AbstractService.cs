using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public abstract class AbstractService<T>
        where T : class 
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<T> _collection;

        protected IMongoDatabase Database()
        {
            return _database;
        }

        protected IMongoCollection<T> Collection()
        {
            return _collection;
        }
       
        protected AbstractService(IMongoDatabase database,string collectionName)
        {
            _database = database;
            _collection = _database.GetCollection<T>(collectionName);
        }
    }
}