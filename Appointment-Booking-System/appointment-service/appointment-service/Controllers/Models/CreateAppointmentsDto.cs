using appointment_service.Persistence.Entities;

namespace appointment_service.Controllers.Models
{
    public class CreateAppointmentRequest
    {
        public Guid BranchId { get; set; }
        public string BranchName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
