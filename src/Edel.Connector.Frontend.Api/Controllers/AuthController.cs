using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Edel.Connector.Frontend.Api.Models.Auths;
using Edel.Connector.Models;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.SwaggerGen;
using Claim = System.Security.Claims.Claim;

namespace Edel.Connector.Frontend.Api.Controllers
{
    [Route("v1/oauth")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public AuthController(IUserService userService, 
            IConfiguration configuration)
        {
            _configuration = configuration;
            _userService = userService;
        }

        [HttpPost]
        [SwaggerOperation(Tags = new[] {"auth"})]
        [Route("token")]
        public async Task<IActionResult> TokenAsync(
            [FromQuery(Name = "grant_type")] string grantType,
            [FromQuery(Name = "username")] string userName,
            [FromQuery(Name = "password")] string password,
            [FromQuery(Name = "refresh_token")] string refreshToken)
        {

            if (string.IsNullOrWhiteSpace(grantType))
                return BadRequest("grant_type is mandatory");
            
            switch (grantType)
            {
                case "password":
                    return await ByPasswordAsync(userName, password);
                case "refresh_token":
                    return await ByRefreshTokenAsync(refreshToken);
                default:
                    return BadRequest($"{grantType} is not valid grant_type");
            }
        }

        private async Task<IActionResult> ByPasswordAsync(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
                return BadRequest("username is mandatory");
            if (string.IsNullOrWhiteSpace(password))
                return BadRequest("password is mandatory");
            
            var user = await _userService.AuthenticateByPassword(userName, password);
            if (user == null) return StatusCode((int) HttpStatusCode.Forbidden);
            return Ok(await BuildTokenAsync(user));
        }

        private async Task<IActionResult> ByRefreshTokenAsync(string refreshToken)
        {
            if (string.IsNullOrWhiteSpace(refreshToken))
                return BadRequest("refresh_token is mandatory");
            var user = await _userService.AuthenticateByRefreshToken(refreshToken);
            if (user == null) return StatusCode((int) HttpStatusCode.Forbidden);
            return Ok(await BuildTokenAsync(user));
        }

        
        private async Task<AuthTokenResponseModel> BuildTokenAsync(User user)
        {
            var claims = new List<Claim> {new Claim(ClaimTypes.Name, user.Username)};
            foreach (var item in user.Claims)
            {
                var scopes = item.Scopes.Select(c=>c.ToString().ToLowerInvariant()).Aggregate((a, b) =>
                {
                    return a + "," + b;
                });
                claims.Add(new Claim(ClaimTypes.Role, $"{item.ResourcePath}:{scopes}"));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes($"{_configuration["Jwt:SecurityKey"]}"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: $"{_configuration["Jwt:ValidIssuer"]}",
                audience: $"{_configuration["Jwt:ValidAudience"]}",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            var refreshToken = await _userService.CreateRefreshTokenAsync(user);
            
            return new AuthTokenResponseModel()
            {
                TokenType = "Bearer",
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpiresIn = 30,
                RefreshToken = refreshToken.Id
            };
        }
    }
}