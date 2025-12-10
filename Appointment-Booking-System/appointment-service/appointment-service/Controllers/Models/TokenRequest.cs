namespace appointment_service.Controllers.Models
{
    public class TokenRequest
    {
        public string ClientId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty;
    }
}
