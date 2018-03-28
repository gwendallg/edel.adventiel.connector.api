using System;
using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data.Repositories;
using Edel.Adventiel.Connector.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Edel.Adventiel.Connector.Api.Controllers
{
    
    /// <summary>
    /// default crud controller
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TEntityPost"></typeparam>
    /// <typeparam name="TEntityPut"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    [Authorize]
    public class DefaultCrudPageableRepositortyController<TEntity, TEntityPost, TEntityPut, TKey>
        : Autumn.Mvc.Data.Controllers.RepositoryControllerAsync<TEntity, TEntityPost, TEntityPut, TKey>
        where TEntity : class where TEntityPost : class where TEntityPut : class
    {
        public DefaultCrudPageableRepositortyController(ICrudPageableRepositoryAsync<TEntity, TKey> repository,
            AutumnSettings settings, IHttpContextAccessor httpContextAccessor)
            : base(repository, settings, httpContextAccessor)
        {
        }

        /// <summary>
        /// on inserting
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override TEntity OnInserting(TEntity entity)
        {
            dynamic e = entity;
            e.Metadata = new MetadataModel
            {
                CreatedDate = DateTime.UtcNow,
                CreatedAt = HttpContext.User.Identity.Name
            };
            return entity;
        }

        /// <summary>
        /// on updating
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override TEntity OnUpdating(TEntity entity)
        {
            dynamic e = entity;
            e.Metadata = new MetadataModel
            {
                LastModifiedDate = DateTime.UtcNow,
                LastModifiedAt = HttpContext.User.Identity.Name
            };
            return entity;
        }
    }
}