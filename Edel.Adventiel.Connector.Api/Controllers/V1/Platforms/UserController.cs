using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Adventiel.Connector.Api.Entities;
using Edel.Adventiel.Connector.Api.Models.V1;
using Edel.Adventiel.Connector.Api.Models.V1.Platforms;
using Edel.Adventiel.Connector.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Api.Controllers.V1.Platforms
{
    [Authorize]
    [Route("v1/user")]
    public class UserController : Controller
    {
        private readonly IMongoDatabase _database;
        private readonly ISecurityService _securityService;
        private readonly IMapper _mapper;

        public UserController(
            IMongoDatabase database,
            ISecurityService securityService,
            IMapper mapper)
        {
            _database = database;
            _securityService = securityService;
            _mapper = mapper;
        }

        [HttpGet("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                var user = await _database
                    .GetCollection<User>("user")
                    .Find(u=>u.Username==userName)
                    .SingleOrDefaultAsync();
                if (user == null)
                    return NotFound();
                var result = _mapper.Map<UserResponseModel>(user);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserPostRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var user = _mapper.Map<User>(model);
                user.Salt = _securityService.GetSalt();
                user.Hash = _securityService.GetHash(model.Password, user.Salt);
                user.Metadata = new MetaDataModel();
                user.Metadata.CreatedDate = DateTime.UtcNow;
                user.Metadata.CreatedAt = HttpContext.User.Identity.Name;
                await _database.GetCollection<User>("user").InsertOneAsync(user);
                var uri = string.Format("{0}/{1}", Request.HttpContext.Request.Path.ToString().TrimEnd('/'),
                    user.Username);
                var result = _mapper.Map<UserResponseModel>(user);
                return Created(uri, result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }

        [HttpPut("{userName}")]
        public async Task<IActionResult> Put(string userName, [FromBody] UserPutRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            User user;
            try
            {
                user = await _database
                    .GetCollection<User>("user")
                    .Find(u => u.Username == userName)
                    .SingleOrDefaultAsync();

                if (user == null)
                    return NotFound();


                user.Claims = model.Claims.ToDictionary(c => c.Type, c => c.Value);
                user.Salt = _securityService.GetSalt();
                user.Hash = _securityService.GetHash(model.Password, user.Salt);
                user.Metadata = new MetaDataModel();
                user.Metadata.LastModifiedDate = DateTime.UtcNow;
                user.Metadata.LastModifiedAt = HttpContext.User.Identity.Name;
                await _database.GetCollection<User>("user").ReplaceOneAsync(u=>u.Username==user.Username,  user);
                var uri = string.Format("{0}/{1}", Request.HttpContext.Request.Path.ToString().TrimEnd('/'),
                    user.Username);
                var result = _mapper.Map<UserResponseModel>(user);
                return Created(uri, result);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    }
}