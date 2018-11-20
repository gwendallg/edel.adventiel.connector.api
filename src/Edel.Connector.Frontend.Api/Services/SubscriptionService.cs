using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Repositories;
using Autumn.Mvc.Models.Paginations;
using Edel.Connector.Api.Models;
using Microsoft.AspNetCore.Http;
using Metadata = Edel.Connector.Api.Models.Metadata;


namespace Edel.Connector.Api.Services
{
    public class SubscriptionService : AbstractService, ISubscriptionService
    {
        private readonly ICrudPageableRepositoryAsync<Subscription, string> _subscriptionrRepository;

        public SubscriptionService(
            IHttpContextAccessor contextAccessor,
            ICrudPageableRepositoryAsync<Subscription, string> subscriptionrRepository)
            : base(contextAccessor)

        {
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
            subscription.LastImportStatus = ImportStatusType.Waiting.ToString();
            await _subscriptionrRepository.InsertAsync(subscription);
            return subscription;
        }

        public async Task<Subscription> FindOneAsync(string userId)
        {
            return await _subscriptionrRepository.FindOneAsync(userId);
        }

        public async Task<IPage<Subscription>> FindAsync(Expression<Func<Subscription, bool>> filter,
            IPageable<Subscription> pageable)
        {
            return await _subscriptionrRepository.FindAsync(filter, pageable);
        }
    }
}