using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public class SubscriptionCollectionService  : AbstractCollectionService<Subscription>, ISubscriptionService
    {
        public SubscriptionCollectionService(IMongoDatabase database) : base(database, "subscription")
        {
        }

        public async Task<Subscription> AddAsync(Subscription subscription, string password, HttpContext context)
        {
            subscription.Password = password.Encrypt();
            subscription.Metadata = new Metadata()
            {
                CreatedDate = DateTime.UtcNow,
                CreatedAt = context == null ? "admin" : context.User.Identity.Name
            };
            await Collection().InsertOneAsync(subscription);
            return subscription;
        }

        public async Task<List<Subscription>> FindToCollectAsync(int size = 10)
        {
            return await Collection().Find(c => true)
                .Sort(Builders<Subscription>.Sort.Descending(x => x.LastCollectTime))
                .Limit(size)
                .ToListAsync();
        }
    }
}