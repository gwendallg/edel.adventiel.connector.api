using Microsoft.AspNetCore.Builder;

namespace Edel.Connector.Frontend.Api
{
    public static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder UseEdelConnector(this IApplicationBuilder application)
        {
            ConnectorHelper.Initialize(application);
            return application;
        }
    }
}