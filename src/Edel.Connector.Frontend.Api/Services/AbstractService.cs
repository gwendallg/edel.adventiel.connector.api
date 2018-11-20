using Microsoft.AspNetCore.Http;

namespace Edel.Connector.Api.Services
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