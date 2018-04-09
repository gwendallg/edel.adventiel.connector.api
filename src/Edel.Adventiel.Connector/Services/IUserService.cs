using System.Threading.Tasks;
using Edel.Adventiel.Connector.Entities;
using Microsoft.AspNetCore.Http;

namespace Edel.Adventiel.Connector.Services
{
    public interface IUserService
    {
        Task<User> AddAsync(User user, string password, HttpContext context);

        Task<User> FindByUserNameAsync(string userName);
        
        Task<User> UpdateAsync(User user, string password, HttpContext context);

        Task<User> Authenticate(string userName, string password);

        void TryAddAdminIfNotExistUsers(string adminPassword = "admin");
    }
}