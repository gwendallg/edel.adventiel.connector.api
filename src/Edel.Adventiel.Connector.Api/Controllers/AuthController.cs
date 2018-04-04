using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Edel.Adventiel.Connector.Api.Models.V1.Platforms;
using Edel.Adventiel.Connector.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Edel.Adventiel.Connector.Api.Controllers
{
    [Route("auth")]
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
        public async Task<IActionResult> Token([FromBody] AuthTokenRequestModel tokenRequestModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            // find user 
            var user = await _userService.Authenticate(tokenRequestModel.Username, tokenRequestModel.Password);
            if (user == null)return StatusCode((int) HttpStatusCode.Forbidden);
            IList<Claim> claims = user.Claims.Select(c => new Claim(c.Key, c.Value)).ToList();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes($"{_configuration["Jwt:SecurityKey"]}"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: $"{_configuration["Jwt:ValidIssuer"]}",
                audience: $"{_configuration["Jwt:ValidAudience"]}",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);
            return Ok(new AuthTokenResponseModel() {Token = new JwtSecurityTokenHandler().WriteToken(token)});
        }

    }
}