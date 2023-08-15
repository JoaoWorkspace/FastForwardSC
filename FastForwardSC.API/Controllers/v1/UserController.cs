using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger<UserController> _logger;

        public UserController(
            IUserService userService,
            ILogger<UserController> logger)
        {
            this.userService = userService;
            _logger = logger;
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<UserDto>> SearchUserAsync(string userId)
        {
            var user = await this.userService.SearchUser(Guid.Parse(userId));
            if (user == null)
            {
                return NotFound();
            }
            return this.Ok(userId);
        }

        [HttpPost("user")]
        public async Task<ActionResult<UserDto>> CreateUserAsync(UserDto user)
        {
            try
            {
                var createdUser = await this.userService.CreateUser(user);
                return this.Ok(createdUser);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new user.");
            }
        }

        [HttpPut("user/{userId}")]
        public async Task<ActionResult<UserDto>> UpdateUserAsync(string userId, UserDto user)
        {
            try
            {
                user.UserId = Guid.Parse(userId);
                var updatedUser = await this.userService.UpdateUser(user);
                return this.Ok(updatedUser);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating user with id {userId}");
            }
        }

        [HttpDelete("user/{userId}")]
        public async Task<ActionResult> RemoveUserAsync(string userId)
        {
            await this.userService.RemoveUser(Guid.Parse(userId));
            return this.Ok("Removed Successfully");
        }
    }
}