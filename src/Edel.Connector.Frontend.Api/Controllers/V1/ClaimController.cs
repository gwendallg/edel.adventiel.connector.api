using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Frontend.Api.Controllers.V1
{
    [Route("v1/claim")]
    public class ClaimController : Controller
    {
        private readonly IClaimsService _claimsService;

        public ClaimController(IClaimsService claimsService)
        {
            _claimsService = claimsService;
        }
        
        /// <summary>
        /// find user
        /// </summary>
        /// <returns></returns>
        [SwaggerOperation( Tags = new []{"claim"})]
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                var result = new Dictionary<string,string>();
                foreach (var item in _claimsService.GetClaimsByResources())
                {
                    var stringBuilder = new StringBuilder();
                    foreach (var scope in item.Value)
                    {
                        stringBuilder.Append(scope + ", ");
                    }

                    result.Add(item.Key, stringBuilder.ToString().Trim().Trim(','));
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    }
}