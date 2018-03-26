using System;
using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data.Repositories;
using Edel.Adventiel.Connector.Api.Models;
using Edel.Adventiel.Connector.Api.Models.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Edel.Adventiel.Connector.Api.Controllers
{
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

        protected override TEntity OnInserting(TEntity entity)
        {
            var element = entity as AbstractElementModel;
            if (element != null)
            {
                element.Metadata = new MetaDataModel();
                element.Metadata.CreatedDate = DateTime.UtcNow;
                element.Metadata.CreatedAt = this.HttpContext.User.Identity.Name;
            }

            return entity;
        }

        protected override TEntity OnUpdating(TEntity entity)
        {
            var element = entity as AbstractElementModel;
            if (element != null && element.Metadata!=null)
            {
                element.Metadata.LastModifiedDate = DateTime.UtcNow;
                element.Metadata.LastModifiedAt = this.HttpContext.User.Identity.Name;
            }
            return base.OnUpdating(entity);
        }
    }
}