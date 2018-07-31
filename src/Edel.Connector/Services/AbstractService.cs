using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Connector.Services
{
    public class AbstractService
    {
        private readonly HttpContext _context;


        protected HttpContext Context()
        {
            return _context;
        }

        protected AbstractService(IHttpContextAccessor contextAccessor)
        {
            _context = contextAccessor?.HttpContext;
        }

    }
}