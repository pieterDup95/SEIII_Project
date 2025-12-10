using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_service.Persistence.Entities
{

    [Table("branch")]
    public class Branch
    {
        public Guid Id { get; init; }
        public string BranchName { get; set; }
        public int BranchCode { get; set; }
        public string Provice { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public ICollection<OperationalHours> OperationalHours { get; set; }
        public int SlotPerHour { get; set; }
    }
}
