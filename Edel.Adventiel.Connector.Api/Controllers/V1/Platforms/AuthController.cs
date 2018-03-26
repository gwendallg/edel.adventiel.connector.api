using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Configurations;
using Edel.Adventiel.Connector.Api.Entities;
using Edel.Adventiel.Connector.Api.Models.V1.Platforms;
using Edel.Adventiel.Connector.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Api.Controllers.V1.Platforms
{
    [Route("v1/auth")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly AutumnDataSettings _settings;
        private readonly IMongoDatabase _database;
        private readonly ISecurityService _securityService;

        public AuthController(
            ISecurityService securityService,
            IMongoDatabase database, 
            AutumnDataSettings settings, 
            IConfiguration configuration)
        {
            _database = database;
            _configuration = configuration;
            _settings = settings;
            _securityService = securityService;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] AuthTokenRequestModel tokenRequestModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            // find user 
            var user = await _database.GetCollection<User>("user")
                .Find(u => u.Username == tokenRequestModel.Username)
                .SingleOrDefaultAsync();

            IEnumerable<Claim> claims;
            // récupération des claims de l'utilisateur
            if (user == null || _securityService.GetHash(tokenRequestModel.Password, user.Salt) != user.Hash)
                return StatusCode((int) HttpStatusCode.Forbidden);

            claims = user.Claims.Select(c => new Claim(c.Key, c.Value));
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