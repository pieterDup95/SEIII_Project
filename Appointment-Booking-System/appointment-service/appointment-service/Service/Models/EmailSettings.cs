// Models/EmailSettings.cs
namespace appointment_service.Models
{
    public class EmailSettings
    {
        public string SendGridApiKey { get; set; } 
        public string FromEmail { get; set; }
        public string FromName { get; set; } 
    }
}