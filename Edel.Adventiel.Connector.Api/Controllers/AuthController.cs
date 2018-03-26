using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Configurations;
using Edel.Adventiel.Connector.Api.Models.V1;
using Edel.Adventiel.Connector.Api.Models.V1.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Edel.Adventiel.Connector.Api.Controllers
{
    [Route("v1/auth")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly AutumnDataSettings _settings;

        public AuthController(AutumnDataSettings settings, IConfiguration configuration)
        {
            _configuration = configuration;
            _settings = settings;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] AuthTokenRequest request)
        {
            if (!ModelState.IsValid)
                return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, request.Username));

            foreach (var item in _settings.Routes.Keys)
            {
                var routeAttribute = _settings.Routes[item];
                var entityType = item.GetGenericArguments()[0];
                var entityInfo = _settings.EntitiesInfos[entityType];
                var stringBuilder =  new StringBuilder();
                stringBuilder.Append("read,");
                if (!entityInfo.IgnoreOperations.Contains(HttpMethod.Post))
                {
                    stringBuilder.Append("create,");
                }
                if (!entityInfo.IgnoreOperations.Contains(HttpMethod.Put))
                {
                    stringBuilder.Append("update,");
                }
                if (!entityInfo.IgnoreOperations.Contains(HttpMethod.Delete))
                {
                    stringBuilder.Append("delete,");
                }
                claims.Add(new Claim(routeAttribute.Template.Replace("/", "_").ToLowerInvariant(), stringBuilder.ToString().Trim(',')));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes($"{_configuration["Jwt:SecurityKey"]}"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: $"{_configuration["Jwt:ValidIssuer"]}",
                audience: $"{_configuration["Jwt:ValidAudience"]}",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new AuthTokenResponse() {Token = new JwtSecurityTokenHandler().WriteToken(token)});

        }

    }
}