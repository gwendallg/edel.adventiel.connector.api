using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Frontend.Api.Controllers.V1
{
    [Authorize]
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
                foreach (var item in _claimsService.GetClaimsByResourcePaths())
                {
                    result.Add(item.Key, _claimsService.ToString(item.Value));
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