using System.Threading.Tasks;
using Edel.Connector.Entities;

namespace Edel.Connector.Services
{
    public interface IUserService
    {
        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> AddAsync(User user, string password);
        
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> UpdateAsync(User user, string password);
        
        /// <summary>
        /// find user by userName
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<User> FindByUserNameAsync(string userName);

        /// <summary>
        /// authenticate user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> Authenticate(string userName, string password);

        /// <summary>
        /// add user admin is not exist
        /// </summary>
        /// <param name="adminPassword"></param>
        void TryAddAdminIfNotExistUsers(string adminPassword = "admin");
    }
}