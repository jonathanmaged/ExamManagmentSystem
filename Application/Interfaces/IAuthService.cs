using Application.Dtos.AuthDto;
using Application.Result;

namespace Application.Interfaces
{
    public interface IAuthService
    {
        Task<Result<bool>> RegisterAsync(RegisterRequest request);
        Task<Result<AccessAndRefreshTokenDto>> LoginAsync(LoginRequest request);
        Task<Result<AccessAndRefreshTokenDto>> ValidateRefreshToken(RefreshTokenRequestDto request);
        Task<Result<bool>> LogoutAsync(LogoutRequest request,string userId);
    }

}
