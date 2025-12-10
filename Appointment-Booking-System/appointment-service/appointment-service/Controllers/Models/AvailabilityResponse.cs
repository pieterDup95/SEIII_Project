namespace appointment_service.Controllers.Models
{
    public class AvailabilityResponse
    {
        public Guid BranchId { get; set; }
        public DateTime date { get; set; }
        public IReadOnlyList<TimeSlot> TimeSlots { get; set; }
    }
    public record TimeSlot(string Time, bool IsAvailable);
}
