using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_service.Persistence.Entities
{
    [Table("customer_info")]
    public class CustomerInfo
    {
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
    }
}
