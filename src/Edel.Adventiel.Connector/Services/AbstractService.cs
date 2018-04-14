using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public class AbstractService
    {
        private readonly IMongoDatabase _database;
        private readonly HttpContext _context;
        
        
        protected IMongoDatabase Database()
        {
            return _database;
        }

        protected HttpContext Context()
        {
            return _context;
        }

        protected AbstractService(IMongoDatabase database, IHttpContextAccessor contextAccessor)
        {
            _database = database;
            _context = contextAccessor?.HttpContext;
        }

    }
}