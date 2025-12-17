namespace appointment_service.Controllers.Models
{
    public class CustomerDto
    {
        public string FullName { get; set; } 
        public string IdNumber { get; set; } 
        public string ContactNumber { get; set; } 
        public string Email { get; set; } 
        public string? Notes { get; set; }
    }
}
