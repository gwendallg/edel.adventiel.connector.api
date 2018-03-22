using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Api.Models.V1;
using Edel.Adventiel.Connector.Api.Models.V1.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Edel.Adventiel.Connector.Api.Controllers.V1
{
    [Route("v1/auth")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] AuthTokenRequest request)
        {
            if (!ModelState.IsValid)
                return StatusCode((int) HttpStatusCode.BadRequest, new ErrorModel(ModelState));
            
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, request.Username),
                new Claim("cattle","read" ), 
                new Claim("cattle_pregnancy-check","read")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes($"{_configuration["Jwt:SecurityKey"]}"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: $"{_configuration["Jwt:ValidIssuer"]}",
                audience: $"{_configuration["Jwt:ValidAudience"]}",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new AuthTokenResponse() { Token = new JwtSecurityTokenHandler().WriteToken(token)});

        }
        
    }
}