using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Connector.Consumer.Api.Models.Users;
using Edel.Connector.Entities;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace Edel.Connector.Consumer.Api.Controllers.V1
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
        public async Task<IActionResult> Post([FromBody] UserPostRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var user = _mapper.Map<User>(model);
                user = await _userService.AddAsync(user, model.Password);
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
    }
}