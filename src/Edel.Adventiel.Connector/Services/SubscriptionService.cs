using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autumn.Mvc.Configurations;
using Edel.Adventiel.Connector.Entities;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public class SubscriptionService  : AbstractCollectionService<Subscription> , ISubscriptionService
    {
        public SubscriptionService(IMongoDatabase database, AutumnSettings settings,
            IHttpContextAccessor contextAccessor) : base(database, contextAccessor, "subscription")

        {
        }

        public async Task<Subscription> AddAsync(Subscription subscription)
        {
            subscription.Metadata = new Metadata
            {
                CreatedAt = Context()?.User?.Identity?.Name,
                CreatedDate = DateTime.UtcNow
            };
            await Collection().InsertOneAsync(subscription);
            return subscription;
        }

        public async Task<List<Subscription>> FindToCollectAsync(int size)
        {
            return new List<Subscription>();
        }
    }
}