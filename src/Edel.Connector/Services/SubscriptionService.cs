using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autumn.Mvc.Configurations;
using Edel.Connector.Entities;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Connector.Services
{
    public class SubscriptionService  : AbstractCollectionService<Subscription> , ISubscriptionService
    {
        public SubscriptionService(IMongoDatabase database, AutumnSettings settings,
            IHttpContextAccessor contextAccessor) : base(database, contextAccessor, "subscription")

        {
        }

        public async Task<Subscription> AddAsync(Subscription subscription, string password)
        {
            subscription.Metadata = new Metadata
            {
                CreatedAt = Context()?.User?.Identity?.Name,
                CreatedDate = DateTime.UtcNow
            };
            subscription.Hash = password.Encrypt();
            await Collection().InsertOneAsync(subscription);
            return subscription;
        }

        public async Task<List<Subscription>> FindToCollectAsync(int size)
        {
            return new List<Subscription>();
        }
    }
}