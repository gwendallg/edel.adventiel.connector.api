using System;
using System.Threading.Tasks;

namespace Edel.Adventiel.Connector.Services
{
    public interface IEdelCollectorService
    {
        Task CollectAsync(string userId, string password,
            DateTime startingDate, DateTime? endingDate = null, string collectorAt = "admin");
    }
}