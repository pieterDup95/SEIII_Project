namespace appointment_service.Controllers.Models
{
    public class AppointmentResponse
    {
        public Guid appointmentId { get; set; } 
        public string referenceNumber { get; set; }
        public Guid branchId { get; set; } 
        public DateTime date { get; set; } 
        public TimeSpan time { get; set; }
        public string status { get; set; } 
        public string? message { get; set; }
    }
}
