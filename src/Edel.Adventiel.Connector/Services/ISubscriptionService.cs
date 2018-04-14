using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities;

namespace Edel.Adventiel.Connector.Services
{
    public interface ISubscriptionService
    {
        Task<Subscription> AddAsync(Subscription subscription);
        Task<List<Subscription>> FindToCollectAsync(int size);
    }
}