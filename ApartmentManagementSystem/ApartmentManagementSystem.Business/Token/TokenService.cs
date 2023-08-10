using ApartmentManagementSystem.ApartmentManagementSystem.Base.ApiResponse;
using ApartmentManagementSystem.ApartmentManagementSystem.Base.Jwt;
using ApartmentManagementSystem.ApartmentManagementSystem.Base.Log;
using ApartmentManagementSystem.ApartmentManagementSystem.Business.AdminLog;
using ApartmentManagementSystem.ApartmentManagementSystem.Data.Uow;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.Token
{
    public class TokenService 
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAdminLogService adminLogService;
        private readonly JwtConfig jwtConfig;
        public TokenService(IUnitOfWork unitOfWork, IAdminLogService userLogService, IOptionsMonitor<JwtConfig> jwtConfig)
        {
            this.unitOfWork = unitOfWork;
            this.adminLogService = userLogService;
            this.jwtConfig = jwtConfig.CurrentValue;
        }
        //public ApiResponse<JwtTokenResponse> Login(JwtTokenRequest request)
        //{
        //    if (request is null)
        //    {
        //        return new ApiResponse<JwtTokenResponse>("Request was null");
        //    }
        //    if (string.IsNullOrEmpty(request.UserName) || string.IsNullOrEmpty(request.Password))
        //    {
        //        return new ApiResponse<JwtTokenResponse>("Request was null");
        //    }

        //    request.UserName = request.UserName.Trim().ToLower();
        //    request.Password = request.Password.Trim();
        //    var user = unitOfWork.UserRepository.Where(x => x.Name.Equals(request.UserName)).FirstOrDefault();
        //    if (user is null)
        //    {
        //        Log(request.UserName, LogType.InValidUserName);
        //        return new ApiResponse<JwtTokenResponse>("Invalid user informations");
        //    }
        //    if (user.Password.ToLower() != CreateMD5(request.Password))
        //    {
        //        user.PasswordRetryCount++;
        //        user.LastActivity = DateTime.UtcNow;

        //        if (user.PasswordRetryCount > 3)
        //            user.Status = 2;

        //        unitOfWork.UserRepository.Update(user);
        //        unitOfWork.Complete();

        //        Log(request.UserName, LogType.WrongPassword);
        //        return new ApiResponse<JwtTokenResponse>("Invalid user informations");
        //    }


        //    if (user.Status != 1)
        //    {
        //        Log(request.UserName, LogType.InValidUserStatus);
        //        return new ApiResponse<JwtTokenResponse>("Invalid user status");
        //    }
        //    if (user.PasswordRetryCount > 3)
        //    {
        //        Log(request.UserName, LogType.PasswordRetryCountExceded);
        //        return new ApiResponse<JwtTokenResponse>("Password retry count exceded");
        //    }

        //    user.LastActivity = DateTime.UtcNow;
        //    user.Status = 1;


        //    unitOfWork.UserRepository.Update(user);
        //    unitOfWork.Complete();


        //    string token = Token(user);

        //    Log(request.UserName, LogType.LogedIn);

        //    JwtTokenResponse response = new()
        //    {
        //        AccessToken = token,
        //        ExpireTime = DateTime.Now.AddMinutes(jwtConfig.AccessTokenExpiration),
        //        UserName = user.Name
        //    };

        //    return new ApiResponse<JwtTokenResponse>(response);
        //}
        //private string Token(User user)
        //{
        //    Claim[] claims = GetClaims(user);
        //    var secret = Encoding.ASCII.GetBytes(jwtConfig.Secret);

        //    var jwtToken = new JwtSecurityToken(
        //        jwtConfig.Issuer,
        //        jwtConfig.Audience,
        //        claims,
        //        expires: DateTime.Now.AddMinutes(jwtConfig.AccessTokenExpiration),
        //        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
        //        );

        //    var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);
        //    return accessToken;
        //}

    }
}
