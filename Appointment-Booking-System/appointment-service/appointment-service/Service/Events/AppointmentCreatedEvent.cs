namespace appointment_service.Service.Events
{
    public record AppointmentCreatedEvent(
        string AppointmentRef,
        string CustomerName,
        string CustomerPhone,
        string CustomerEmail,
        string Branch,
        string Date,
        string Time
    );
}
