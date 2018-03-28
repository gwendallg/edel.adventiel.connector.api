using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Autumn.Mvc.Data.Models;
using Edel.Adventiel.Connector.Api.Entities;
using Edel.Adventiel.Connector.Api.Models.V1.Platforms;
using Edel.Adventiel.Connector.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edel.Adventiel.Connector.Api.Controllers.V1.Platforms
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

        [HttpGet("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                var user = await _userService.FindByUserNameAsync(userName);
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
                user = await _userService.AddAsync(user, model.Password, HttpContext);
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
                user = await _userService.FindByUserNameAsync(userName);
                user = _mapper.Map<User>(model);
                if (user == null)
                    return NotFound();
                user.Claims = user.Claims;
                await _userService.UpdateAsync(user, model.Password, HttpContext);
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