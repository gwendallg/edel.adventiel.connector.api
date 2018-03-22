using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Models.Paginations;
using Edel.Adventiel.Connector.Api.Models;

namespace Edel.Adventiel.Connector.Api.Repositories
{
    /// <summary>
    /// inteface of CRUD repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICrudPageableRepositoryAsync<TEntity>
        where TEntity : AbstractElementModel
    {
        /// <summary>
        /// find enity by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindOneAsync(string id);

        /// <summary>
        /// find entity by criteria
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageable"></param>
        /// <returns></returns>
        Task<IPage<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter=null, IPageable<TEntity> pageable=null);

        /// <summary>
        /// create entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity, string id);

        /// <summary>
        /// delete entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> DeleteAsync(string id);
        
        /// <summary>
        /// count entities by criteria
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<long> CountAsync(Expression<Func<TEntity, bool>> filter=null);
    }
}