namespace appointment_service.Controllers.Models
{
    public class BranchDto
    {
        public Guid Id { get; set; }
        public string BranchName { get; set; }
        public int BranchCode { get; set; }
        public string Provice { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int SlotDuration { get; set; }
        public int AppointmentsPerSlot { get; set; }
        public List<OperationalHoursDto>? OperationalHours { get; set; }
        public List<string> PublicHolidays { get; set; }
    }
}
