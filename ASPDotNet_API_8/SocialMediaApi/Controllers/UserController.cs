using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using SocialMediaApi.BL;
using SocialMediaApi.BL.DTO.User;
using SocialMediaApi.DAL;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _manager;
        private readonly UserManager<User> _userManagerIdentity;

        public UserController(IUserManager manager, UserManager<User> userManagerIdentity)
        {
            _manager = manager;
            _userManagerIdentity = userManagerIdentity;
        }


        #region Authentication
        [HttpPost("login")]
        public async Task<Results<Ok<Token>, UnauthorizedHttpResult>> Login(UserLogin _user)
        {
            var user = await _userManagerIdentity.FindByEmailAsync(_user.Email);
            if (user is null) return TypedResults.Unauthorized();
            var isValidPass = await _userManagerIdentity.CheckPasswordAsync(user, _user.Password);
            if (!isValidPass) return TypedResults.Unauthorized();
            var claims = await _userManagerIdentity.GetClaimsAsync(user);
            var token = await _manager.GenerateTokenAsync(claims.ToList());
            return TypedResults.Ok(token);
        }
        [HttpPost("register")]
        public async Task<Results<Ok, BadRequest<List<string>>>> register(UserCreate _user)
        {
            var user = new User()
            {
                Email = _user.Email,
                UserName = _user.Name,
                Name = _user.Name,
            };
            var result =await _userManagerIdentity.CreateAsync(user, _user.Password);
            if(!result.Succeeded)return TypedResults.BadRequest(result.Errors.Select(e=>e.Description).ToList());
            var claims = new List<Claim>
            {
                new (ClaimTypes.NameIdentifier, user.Id.ToString()),
                new (ClaimTypes.Email, user.Email.ToString()),
                new (ClaimTypes.Role, _user.Role),
            };
            await _userManagerIdentity.AddClaimsAsync(user, claims);
            return TypedResults.Ok();
        }
        [HttpGet("ForAdminOnly")]
        [Authorize(Policy = "ForAdminOnly")]
        public async Task<Ok<List<UserRead>>> GetAllForAdmin() => TypedResults.Ok(await _manager.GetAllAsync());
        [HttpGet("ForUser")]
        [Authorize(Policy = "ForUser")]
        public async Task<Ok<List<UserRead>>> GetAllForUser() => TypedResults.Ok(await _manager.GetAllAsync());
        #endregion
    }
}

