using System;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Autumn.Mvc.Data.Repositories;
using Autumn.Mvc.Models.Paginations;
using Edel.Connector.Api.Models;
using Edel.Connector.Api.Models.Subscriptions;
using Edel.Connector.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Api.Controllers.V1
{
    [Authorize]
    [Route("v1/subscription")]
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;

        public SubscriptionController(
            ISubscriptionService subscriptionService,
            ICrudPageableRepositoryAsync<Subscription,string> crudPageableRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _subscriptionService = subscriptionService;
        }

        [HttpPost]
        [SwaggerOperation(Tags = new[] {"subscription"})]
        public async Task<IActionResult> Post([FromBody] SubscriptionPostRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var subscription = _mapper.Map<Subscription>(model);
                subscription = await _subscriptionService.AddAsync(subscription, model.Password);
                return Created(HttpContext.Request.QueryString.Value.TrimEnd('/') + "/" + subscription.UserId,
                    subscription);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
        
        /// <summary>
        /// find user
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [HttpGet("{userid}")]
        [SwaggerOperation( Tags = new []{"subscription"})]
        public async Task<IActionResult> Get(string userid)
        {
            try
            {
                var subscription = await _subscriptionService.FindOneAsync(userid);
                if (subscription == null)
                    return NotFound();
                return Ok(subscription);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }

        [HttpGet]
        [SwaggerOperation(Tags = new[] {"subscription"})]
        public async Task<IActionResult> Get(Expression<Func<Subscription, bool>> filter,
            IPageable<Subscription> pageable)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(await _subscriptionService.FindAsync(filter, pageable));
        }
    }
}