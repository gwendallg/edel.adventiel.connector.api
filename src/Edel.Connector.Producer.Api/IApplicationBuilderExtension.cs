using Hangfire;
using Microsoft.AspNetCore.Builder;

namespace Edel.Connector.Frontend.Api
{
    public static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder UseEdel(this IApplicationBuilder application)
        {
            RecurringJob.AddOrUpdate("edel-refresh-data", () => NotifyRefreshEdelDataRequest(), "* * * * *");
            return application;
        }

        public static void NotifyRefreshEdelDataRequest()
        {
            
            /*
          *    public async Task NotifyRefreshDataAsync(int size = 100)
     {
         var subscriptions = await _subscriptionrRepository
             .FindAsync(s => s.LastImportStatus == ImportStatusType.Waiting.ToString() &&
                             (s.LastImportDate == null || s.LastImportDate < DateTime.UtcNow.Date),new Pageable<Subscription>(0, size));

         using (var producer =
             new Producer<Null, BreederDataRefreshMessage>(_messageService.GetConfiguration(), null,
                 new BreederDataRefershMessageSerializer()))
         {
             foreach (var subscription in subscriptions.Content)
             {
                 var message =
                     new BreederDataRefreshMessage() {Identifier = subscription.UserId, IsHealthCheck = false};
                 await producer.ProduceAsync(_messageService.GetRefreshDataRequestTopic(), null, message);
             }
             producer.Flush(100);
         }
     }

          */

/*
            BackgroundJob.Enqueue<ISubscriptionService>(subscriptionService =>
                subscriptionService.NotifyRefreshDataAsync(10)
            );
*/
        }
    }
}