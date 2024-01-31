namespace JWT.APP.Back.Infrastructure.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "this is my custom Secret key for authentication";
        public const int Expire = 5;
    }
}
