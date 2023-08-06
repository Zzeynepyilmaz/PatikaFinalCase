namespace ApartmentManagementSystem.ApartmentManagementSystem.Base.Jwt
{
    public class JwtTokenResponse
    {
        public DateTime ExpireTime { get; set; }
        public string AccessToken { get; set; }
        public string UserName { get; set; }
    }
}
