using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Consumer.Api.Models.Subscriptions;
using Edel.Connector.Entities;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Consumer.Api.Controllers.V1
{
    [Authorize]
    [Route("v1/subscription")]
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;

        public SubscriptionController(
            ISubscriptionService subscriptionService,
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
    }
}