using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Base.Jwt;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using Microsoft.Extensions.Options;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.Token
{
    public class TokenService : ITokenService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserLogService userLogService;
        private readonly JwtConfig jwtConfig;
        public TokenService(IUnitOfWork unitOfWork, IUserLogService userLogService, IOptionsMonitor<JwtConfig> jwtConfig)
        {
            this.unitOfWork = unitOfWork;
            this.userLogService = userLogService;
            this.jwtConfig = jwtConfig.CurrentValue;
        }

        public ApiResponse<JwtTokenResponse> Login(JwtTokenRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
