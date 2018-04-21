using System.Threading.Tasks;

namespace Edel.Adventiel.Connector.Services
{
    public interface ICollectorService
    {
        Task CollectAsync(string userId);
    }
}