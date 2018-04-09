using System.Collections.Generic;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities;
using Microsoft.AspNetCore.Http;

namespace Edel.Adventiel.Connector.Services
{
    public interface ISubscriptionService
    {
        Task<Subscription> AddAsync(Subscription subscription, string password, HttpContext context);

        Task<List<Subscription>> FindToCollectAsync(int size);
    }
}