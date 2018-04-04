using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities.Subscriptions;
using Microsoft.AspNetCore.Http;

namespace Edel.Adventiel.Connector.Services
{
    public interface IEdelSubscriptionService
    {
        Task<EdelSubscription> AddAsync(EdelSubscription edelSubscription, string password, HttpContext context);

        Task<List<EdelSubscription>> FindToCollectAsync(int size);
    }
}