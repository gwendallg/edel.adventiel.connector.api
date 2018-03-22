using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using Autumn.Mvc.Models.Paginations;
using Edel.Adventiel.Connector.Api.Models;
using Edel.Adventiel.Connector.Api.Models.V1;
using Edel.Adventiel.Connector.Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edel.Adventiel.Connector.Api.Controllers
{
    [Authorize]
    public abstract class AbstractController<TDocument> : Controller
        where TDocument : AbstractElementModel
    {
        private readonly ICrudPageableRepositoryAsync<TDocument> _repository;

        protected AbstractController(ICrudPageableRepositoryAsync<TDocument> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageable"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(Expression<Func<TDocument, bool>> filter,
            IPageable<TDocument> pageable)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));
             
                return Ok(await _repository.FindAsync(filter, pageable));
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModel(e));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));
                return Ok(await _repository.FindOneAsync(id));
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModel(e));
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] [Required] TDocument document)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));

                document.Metadata = new MetaDataModel();
                document.Metadata.CreatedAt = "";
                document.Metadata.CreatedDate = DateTime.Now;
                document.Metadata.LastModifiedAt = null;
                document.Metadata.LastModifiedDate = null;

                var result = await _repository.InsertAsync(document);
                var uri = string.Format("{0}/{1}", Request.HttpContext.Request.Path.ToString().TrimEnd('/'), result.Id);
                return Created(uri, result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModel(e));
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));

                var result = await _repository.FindOneAsync(id);
                if (result == null) return NoContent();
                result = await _repository.DeleteAsync(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModel(e));
            }
        }
    }
}