using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Api.Models;
using Edel.Connector.Api.Models.Users;
using Edel.Connector.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Api.Controllers.V1
{
    [Authorize]
    [Route("v1/user")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(
            IUserService userService,
            IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
        }

        /// <summary>
        /// find user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet("{userName}")]
        [SwaggerOperation( Tags = new []{"user"})]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                var user = await _userService.FindByUserNameAsync(userName);
                if (user == null)
                    return NotFound();
                return Ok(user);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }

        /// <summary>
        /// create new user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerOperation( Tags = new []{"user"})]
        [SwaggerResponse(200,Type=typeof(User))]
        [SwaggerResponse(404)]
        [SwaggerResponse(400,Type=typeof(ErrorModelInternalError))]
        [SwaggerResponse(500,Type=typeof(ErrorModelInternalError))]
        public async Task<IActionResult> Post([FromBody] UserPostRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var user = _mapper.Map<User>(model);
                user = await _userService.InsertAsync(user, model.Password);
                var uri = string.Format("{0}/{1}", Request.HttpContext.Request.Path.ToString().TrimEnd('/'),
                    user.Username);
                return Created(uri, user);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }

        /// <summary>
        /// update user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{userName}")]
        [SwaggerOperation( Tags = new []{"user"})]
        [SwaggerResponse(200,Type=typeof(User))]
        [SwaggerResponse(404)]
        [SwaggerResponse(500,Type=typeof(ErrorModelBadRequest))]
        public async Task<IActionResult> Put(string userName, [FromBody] UserPutRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var user = await _userService.FindByUserNameAsync(userName);
                if (user == null)
                    return NotFound();
                user = _mapper.Map<User>(model);
                user.Username = userName;
                user.Claims = user.Claims;
                await _userService.UpdateAsync(user, model.Password);
                return Ok(user);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }

        [HttpDelete("{userName}")]
        [SwaggerOperation( Tags = new []{"user"})]
        [SwaggerResponse(200)]
        public async Task<IActionResult> Delete(string userName)
        {
            try
            {
                var user = await _userService.FindByUserNameAsync(userName);
                if (user == null)
                    return NotFound();
               await _userService.DeleteAsync(user);
               return Ok();
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, new ErrorModelInternalError(e));
            }
        }
    }
}