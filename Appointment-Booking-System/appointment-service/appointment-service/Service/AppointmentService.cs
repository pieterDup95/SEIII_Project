using appointment_service.Common.Exception;
using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;
using appointment_service.Persistence.Repositories;
using appointment_service.Service.Events;
using appointment_service.Service.Interfaces;

namespace appointment_service.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ILogger<AppointmentService> _logger;
        private readonly IAppointmentRepository _repository;
        private readonly INotificationService _notificationService;

        public AppointmentService(ILogger<AppointmentService> logger, IAppointmentRepository repository, INotificationService notificationService)
        {
            _logger = logger;
            _repository = repository;
            _notificationService = notificationService;
        }

        public async Task<AppointmentResponse> BookAppointmentAsync(CreateAppointmentRequest request, CancellationToken cancellationToken)
        {

            var idNumber = request.Customer.IdNumber.Trim();
            AppointmentRequest? existingAppointment;

            try
            {
                existingAppointment = await _repository.LookupAppointmentAsync(idNumber, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database unavailable while checking existing appointment");
                throw ex;
            }

            if (existingAppointment != null)
            {
                throw new DuplicateBookingException(new
                {
                    referenceNumber = existingAppointment.ReferenceNumber,
                    branchName = existingAppointment.BranchId,
                    date = existingAppointment.Date.ToString("yyyy-MM-dd"),
                    time = existingAppointment.Time.ToString(@"hh\:mm")
                });
            }
            try
            {
                var appointmentResponse = await _repository.BookAppointmentAsync(request, cancellationToken);

                var evt = new AppointmentCreatedEvent(
                                    appointmentResponse.referenceNumber,
                                    request.Customer.FullName,
                                    request.Customer.ContactNumber,
                                    request.Customer.Email,
                                    request.BranchName,
                                    request.Date.ToString("yyyy-MM-dd"),
                                    request.Time
                                 );
                await _notificationService.SendAppointmentCreatedAsync(evt);

                return appointmentResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error booking appointment");
                throw ex;
            }
        }

        public async Task<bool> CancelAppointmentAsync(string referenceNumber,CancellationToken ct)
        {
            return await _repository.CancelAppointmentAsync(referenceNumber, ct);
        }
    }
}


