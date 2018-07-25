using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Connector.Services
{
    public abstract class AbstractCollectionService<T> : AbstractService
        where T : class 
    {
        private readonly IMongoCollection<T> _collection;

        /// <summary>
        /// get collection 
        /// </summary>
        /// <returns></returns>
        protected IMongoCollection<T> Collection()
        {
            return _collection;
        }

        /// <summary>
        /// initialize a new instance of AbstractCollectionService
        /// </summary>
        /// <param name="database"></param>
        /// <param name="contextAccessor"></param>
        /// <param name="collectionName"></param>
        protected AbstractCollectionService(IMongoDatabase database, IHttpContextAccessor contextAccessor,
            string collectionName) : base(database, contextAccessor)
        {
            _collection = Database().GetCollection<T>(collectionName);
        }
    }
}