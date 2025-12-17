using appointment_service.Service.Events;

namespace appointment_service.Service.Interfaces
{
    public interface INotificationService
    {
        Task SendAppointmentCreatedAsync(AppointmentCreatedEvent evt);
    }
}
