using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Repositories;
using Autumn.Mvc.Models.Paginations;
using Confluent.Kafka;
using Edel.Connector.Entities;
using Edel.Connector.Messages;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using Metadata = Edel.Connector.Entities.Metadata;

namespace Edel.Connector.Services
{
    public class SubscriptionService : AbstractService, ISubscriptionService
    {
        private readonly IMessageService _messageService;
        private readonly ICrudPageableRepositoryAsync<Subscription, string> _subscriptionrRepository;

        public SubscriptionService(IMongoDatabase database,
            IHttpContextAccessor contextAccessor,
            ICrudPageableRepositoryAsync<Subscription, string> subscriptionrRepository, IMessageService messageService)
            : base(contextAccessor)

        {
            _messageService = messageService;
            _subscriptionrRepository = subscriptionrRepository;
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
            await _subscriptionrRepository.InsertAsync(subscription);
            return subscription;
        }

        public async Task<Subscription> FindOneAsync(string userId)
        {
            return await _subscriptionrRepository.FindOneAsync(userId);
        }

        public async Task<IPage<Subscription>> FindAsync(Expression<Func<Subscription, bool>> filter, IPageable<Subscription> pageable)
        {
            return await _subscriptionrRepository.FindAsync(filter, pageable);
        }

        public async Task NotifyRefreshDataAsync(int size = 100)
        {
            var subscriptions = await _subscriptionrRepository
                .FindAsync(s => s.LastImportStatus == ImportStatusType.Waiting &&
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
    }
}