namespace NguyenThiNgocChau_2122110055.Auth
{
    public class JwtSettings
    {
        public string SecretKey { get; set; } = "THIS_IS_A_SUPER_SECRET_KEY_1234567890_32";
        public string Issuer { get; set; } = "NguyenThiNgocChau_2122110055App";
        public string Audience { get; set; } = "NguyenThiNgocChau_2122110055Users";
        public int ExpirationMinutes { get; set; } = 60;
    }
}
