using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Autumn.Mvc.Data.Configurations;
using Autumn.Mvc.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Adventiel.Connector.Api.Controllers.V1
{
    [Route("v1/claim")]
    public class ClaimController : Controller
    {
        private readonly AutumnDataSettings _dataSettings;

        public ClaimController(AutumnDataSettings dataSettings)
        {
            _dataSettings = dataSettings;
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
                var result = new Dictionary<string, string>();

                foreach (var info in _dataSettings.EntitiesInfos.Values)
                {
                    var claimKey = string.Format("{0}_{1}", info.ApiVersion, info.Name);
                    var stringBuilder = new StringBuilder();
                    stringBuilder.Append("read, ");
                    if (!info.IgnoreOperations.Contains(HttpMethod.Post))
                        stringBuilder.Append("create, ");
                    if (!info.IgnoreOperations.Contains(HttpMethod.Put))
                        stringBuilder.Append("update, ");
                    if (!info.IgnoreOperations.Contains(HttpMethod.Delete))
                        stringBuilder.Append("delete, ");
                    var claimValue = stringBuilder.ToString().Trim().TrimEnd(',');
                    result.Add(claimKey, claimValue);
                }
                result.Add("v1_user","read, create, update");
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    }
}