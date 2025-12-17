using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;

namespace appointment_service.Service.Interfaces
{
    public interface IAppointmentService
    {
        Task<AppointmentResponse> BookAppointmentAsync(CreateAppointmentRequest request, CancellationToken cancellationToken);
        Task<bool> CancelAppointmentAsync(string referenceNumber, CancellationToken cancellationToken);
    }
}
