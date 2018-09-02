using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Frontend.Api.Models.Claims;
using Edel.Connector.Models;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Frontend.Api.Controllers
{
    [Authorize]
    [Route("v1/claim")]
    public class ClaimController : Controller
    {
        private readonly IClaimsService _claimsService;
        private readonly IMapper _mapper;

        public ClaimController(IClaimsService claimsService,IMapper mapper)
        {
            _claimsService = claimsService;
            _mapper = mapper;
        }
        
        /// <summary>
        /// find user
        /// </summary>
        /// <returns></returns>
        [SwaggerOperation( Tags = new []{"claim"})]
        [SwaggerResponse(200,typeof(ClaimResponseModel[]))]
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                var dto = _mapper.Map <List<Claim>, List<ClaimResponseModel>>(_claimsService.All().ToList());
                return Ok(dto);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    }
}