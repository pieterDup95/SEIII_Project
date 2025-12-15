namespace appointment_service.Persistence.Entities
{
    public class BranchHoliday
    {
        public Guid Id { get; set; }

        public Guid BranchId { get; set; }
        public Branch Branch { get; set; } = null!;

        public DateOnly Date { get; set; }

        public string? Description { get; set; } 
    }

}
