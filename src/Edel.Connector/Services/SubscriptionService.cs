using System;
using System.Threading.Tasks;
using Autumn.Mvc.Configurations;
using Confluent.Kafka;
using Edel.Connector.Entities;
using Edel.Connector.Messages;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using Metadata = Edel.Connector.Entities.Metadata;

namespace Edel.Connector.Services
{
    public class SubscriptionService : AbstractCollectionService<Subscription>, ISubscriptionService
    {
        private readonly IMessageService _messageService;

        public SubscriptionService(IMongoDatabase database, AutumnSettings settings,
            IHttpContextAccessor contextAccessor, IMessageService messageService) : base(database, contextAccessor,
            "subscription")

        {
            _messageService = messageService;
        }

        public async Task<Subscription> AddAsync(Subscription subscription, string password)
        {
            subscription.Metadata = new Metadata
            {
                CreatedAt = Context()?.User?.Identity?.Name,
                CreatedDate = DateTime.UtcNow
            };
            subscription.Hash = password.Encrypt();
            subscription.LastImportStatus = ImportStatusType.Waiting;
            await Collection().InsertOneAsync(subscription);
            return subscription;
        }

        public async Task<Subscription> FindOneAsync(string userId)
        {
            return await Collection().Find(e => e.UserId == userId).SingleOrDefaultAsync();
        }

        public async Task NotifyRefreshDataAsync(int size = 100)
        {
            var subscriptions = await Collection()
                .Find(s => s.LastImportStatus == ImportStatusType.Waiting &&
                           (s.LastImportDate == null || s.LastImportDate < DateTime.UtcNow.Date)).Limit(size)
                .ToListAsync();

            using (var producer =
                new Producer<Null, BreederDataRefreshMessage>(_messageService.GetConfiguration(), null,
                    new BreederDataRefershMessageSerializer()))
            {
                foreach (var subscription in subscriptions)
                {
                    var message =
                        new BreederDataRefreshMessage() {Identifier = subscription.UserId, IsHealthCheck = false};
                    await producer.ProduceAsync(_messageService.GetRefreshDataRequestTopic(), null, message);
                }

                producer.Flush(100);
            }
        }
    }
}