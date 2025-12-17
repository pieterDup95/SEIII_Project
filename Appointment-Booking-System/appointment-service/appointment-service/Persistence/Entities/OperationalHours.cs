using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_service.Persistence.Entities
{
    [Table("operational_hours")]
    public class OperationalHours
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid BranchId { get; set; }  

        [Required]
        public DayOfWeek DayOfWeek { get; set; }  

        [Required]
        public TimeSpan OpenTime { get; set; }

        [Required]
        public TimeSpan CloseTime { get; set; }
        public Branch Branch { get; set; }
    }
}
