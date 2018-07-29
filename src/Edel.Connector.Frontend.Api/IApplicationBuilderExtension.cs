using Edel.Connector.Services;
using Hangfire;
using Microsoft.AspNetCore.Builder;

namespace Edel.Connector.Frontend.Api
{
    public static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder UseEdelConnector(this IApplicationBuilder application)
        {
            ConnectorHelper.Initialize(application);
            RecurringJob.AddOrUpdate("edel-refresh-data", () => NotifyRefreshEdelDataRequest(), "* * * * *");
            return application;
        }

        public static void NotifyRefreshEdelDataRequest()
        {

            BackgroundJob.Enqueue<ISubscriptionService>(subscriptionService =>
                subscriptionService.NotifyRefreshDataAsync(10)
            );

        }
    }
}