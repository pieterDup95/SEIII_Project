using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_service.Persistence.Entities
{
    [Table("appointment_request")]
    public class AppointmentRequest
    {
        [Key]
        public Guid Id { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid BranchId { get; set; }
        public DateOnly Date { get; set; }
        public TimeSpan Time { get; set; }
        public CustomerInfo Customer { get; set; }
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
