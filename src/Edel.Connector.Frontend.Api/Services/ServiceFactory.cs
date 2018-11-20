using System;

namespace Edel.Connector.Api.Services
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;
        
        public ServiceFactory(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public T Get<T>()
        {
            return (T) _serviceProvider.GetService(typeof(T));
        }
    }
}