using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Base.Jwt;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.Token
{
    public interface ITokenService
    {
        ApiResponse<JwtTokenResponse> Login(JwtTokenRequest request);
    }
}
