using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data.Repositories;
using Autumn.Mvc.Models.Paginations;
using Edel.Connector.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Edel.Connector.Api.Controllers
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

        private readonly ILogger<TEntity> _logger;

        /// <summary>
        /// initialize a new instance of controller
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="settings"></param>
        /// <param name="httpContextAccessor"></param>
        public DefaultCrudPageableRepositortyController(ICrudPageableRepositoryAsync<TEntity, TKey> repository,
            AutumnSettings settings, IHttpContextAccessor httpContextAccessor, ILogger<TEntity> logger)
            : base(repository, settings, httpContextAccessor)
        {
            _logger = logger;
        }

        /// <summary>
        /// on inserting
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override TEntity OnInserting(TEntity entity)
        {
            if (entity is IMetadataeable metadataeable)
            {
                metadataeable.Metadata = new Metadata()
                {
                    CreatedDate = DateTime.UtcNow,
                    CreatedAt = HttpContext.User.Identity.Name
                };
            }
            return entity;
        }


        public override Task<IActionResult> Get(Expression<Func<TEntity, bool>> filter, IPageable<TEntity> pageable)
        {
            return base.Get(filter, pageable);
        }

        /// <summary>
        /// on updating
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override TEntity OnUpdating(TEntity entity)
        {
            if (entity is IMetadataeable metadataeable)
            {
                metadataeable.Metadata = new Metadata()
                {
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedAt = HttpContext.User.Identity.Name
                };
            }
            return entity;
        }
    }
}