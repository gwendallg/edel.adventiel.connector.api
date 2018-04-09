using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public abstract class AbstractCollectionService<T> : AbstractService
        where T : class 
    {
        private readonly IMongoCollection<T> _collection;

    
        protected IMongoCollection<T> Collection()
        {
            return _collection;
        }

        protected AbstractCollectionService(IMongoDatabase database, string collectionName) : base(database)
        {
            _collection = Database().GetCollection<T>(collectionName);
        }
    }
}