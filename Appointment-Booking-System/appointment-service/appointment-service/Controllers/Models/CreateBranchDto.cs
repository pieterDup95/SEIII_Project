public class CreateBranchDto
{
    public string BranchName { get; set; }
    public int BranchCode { get; set; }
    public string Provice { get; set; }
    public string City { get; set; }
    public string Suburb { get; set; }
    public string Address { get; set; }
    public int AppointmentsPerSlot { get; set; }
    public int SlotDuration { get; set; } 
    public List<CreateOperationalHoursDto>? OperationalHours { get; set; }
}