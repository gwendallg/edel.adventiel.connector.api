using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities.Subscriptions;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Services
{
    public class EdelSubscriptionService  : AbstractService<EdelSubscription>, IEdelSubscriptionService
    {
        public EdelSubscriptionService(IMongoDatabase database) : base(database, "edleSubscription")
        {
        }

        public Task<EdelSubscription> AddAsync(EdelSubscription edelSubscription, string password, HttpContext context)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<EdelSubscription>> FindToCollectAsync(int size = 10)
        {
            return await Collection().Find(c => true)
                .Sort(Builders<EdelSubscription>.Sort.Descending(x => x.LastCollectTime))
                .Limit(size)
                .ToListAsync();
        }
    }
}