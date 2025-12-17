namespace appointment_service.Controllers.Models
{
    public class ClientCredentials
    {
        public string ClientId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty; 
        public List<string> Roles { get; set; } = new();
    }
}
