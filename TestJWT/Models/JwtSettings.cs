namespace TestJWT.Models
{
    public class JwtSettings
    {
        public string SecreyKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationMinutes { get; set; }  
    }
}
