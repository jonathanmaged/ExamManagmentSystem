using System.Security.Claims;
using Application.Dtos.AuthDto;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await authService.RegisterAsync(request);
            return result.StatusCode switch
            {
                201 or 409  => StatusCode(result.StatusCode, result.Message),
                400 => StatusCode(result.StatusCode, result.ErrorList),
            };
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await authService.LoginAsync(request);
            if (!result.IsSuccess) { 
                return Unauthorized(result.Message);
            
            } 
            return Ok(result.Data);
        }


        [HttpPost("refresh-Token")]
        public async Task<IActionResult> ValidateRefreshToken(RefreshTokenRequestDto request)
        {
            var result = await authService.ValidateRefreshToken(request);

            if (!result.IsSuccess)
            {
                return Unauthorized(result.Message);

            }
            return Ok(result.Data);

        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout(LogoutRequest request)
        {
            var publicUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var result = await authService.LogoutAsync(request,publicUserId);
            if (!result.IsSuccess)
            {

            }
            return Ok(result.Message);
        }
        


    }
}
