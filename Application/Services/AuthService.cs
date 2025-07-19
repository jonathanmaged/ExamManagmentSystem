using Application.Dtos.AuthDto;
using Application.Interfaces;
using Application.Result;
using AutoMapper;

namespace Application.Services
{
    public class AuthService(IUserManagerService userManagerService, IMapper mapper  ) : IAuthService
    {
        public async Task<Result<bool>> RegisterAsync(RegisterRequest request)
        {
            mapper.Map<>()
            var result = await userManagerService.CreateUserAsync(request);
            return result;              
        }

        public Task<Result<AccessAndRefreshTokenDto>> LoginAsync(LoginRequest request)
        {

        }
        public Task<Result<AccessAndRefreshTokenDto>> ValidateRefreshToken(RefreshTokenRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> LogoutAsync(LogoutRequest request, string userId)
        {
            throw new NotImplementedException();
        }

    }
}
