using System.Threading.Tasks;
using Edel.Connector.Api.Models;

namespace Edel.Connector.Api.Services
{
    public interface IUserService
    {
        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> InsertAsync(User user, string password);
        
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> UpdateAsync(User user, string password);

        /// <summary>
        /// delete user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task DeleteAsync(User user);
        
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
        Task<User> AuthenticateByPassword(string userName, string password);
        
        /// <summary>
        /// authenticate user
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        Task<User> AuthenticateByRefreshToken(string refreshToken);

        /// <summary>
        /// create a refresh token
        /// </summary>
        /// <param name="user"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        Task<RefreshToken> CreateRefreshTokenAsync(User user, int duration = 120);

        /// <summary>
        /// add user admin is not exist
        /// </summary>
        /// <param name="adminPassword"></param>
        Task TryAddAdminIfNotExistUsersAsync(string adminPassword = "admin");
    }
}