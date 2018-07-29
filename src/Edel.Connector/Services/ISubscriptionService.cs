using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Connector.Entities;

namespace Edel.Connector.Services
{
    public interface ISubscriptionService
    {
        /// <summary>
        /// add new subscription
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<Subscription> AddAsync(Subscription subscription, string password);

        Task<Subscription> FindOneAsync(string userId);

        Task NotifyRefreshDataAsync(int size);
    }
}