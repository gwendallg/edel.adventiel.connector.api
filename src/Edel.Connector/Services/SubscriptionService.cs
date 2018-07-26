using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autumn.Mvc.Configurations;
using Edel.Connector.Entities;
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
            subscription.LastImportStatus = ImportStatusType.Waiting;
            await Collection().InsertOneAsync(subscription);
            return subscription;
        }

        public async Task<Subscription> FindOneAsync(string userId)
        {
            return await Collection().Find(e => e.UserId == userId).SingleOrDefaultAsync();
        }

        public async Task<List<Subscription>> FindToCollectAsync(int size = 100)
        {
            return await Collection()
                .Find(s => s.LastImportStatus == ImportStatusType.Waiting &&
                           (s.LastImportDate == null || s.LastImportDate < DateTime.UtcNow.Date)).Limit(size)
                .ToListAsync();
        }
    }
}