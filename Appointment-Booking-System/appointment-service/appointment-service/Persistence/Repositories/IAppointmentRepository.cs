using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;

namespace appointment_service.Persistence.Repositories
{
    public interface IAppointmentRepository
    {
        Task<AppointmentResponse> BookAppointmentAsync(CreateAppointmentRequest request, CancellationToken cancellationToken);
        Task<AppointmentRequest> LookupAppointmentAsync(string idNumber, CancellationToken cancellationToken);
        Task<bool> CancelAppointmentAsync(string referenceNumber, CancellationToken cancellationToken);
    }
}
