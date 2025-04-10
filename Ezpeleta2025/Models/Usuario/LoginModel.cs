namespace Ezpeleta2025.Models.Usuario
{
    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class RefreshTokenRequest
{
    public string Email { get; set; }
    public string RefreshToken { get; set; }
}

public class LogoutRequest
{
    public string Email { get; set; }
}
}