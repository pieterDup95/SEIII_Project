using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Threading;

namespace appointment_service.Persistence.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public AppointmentRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<AppointmentResponse> BookAppointmentAsync(CreateAppointmentRequest request, CancellationToken cancellationToken)
        {

            var id = Guid.NewGuid();
            var shortRef = "PB-" + (Math.Abs(id.GetHashCode()) % 1_000_000).ToString("D6");

            var entity = new AppointmentRequest
            {
                Id = id,
                ReferenceNumber = shortRef,
                BranchId = request.BranchId,
                Date = DateOnly.FromDateTime(request.Date),
                Time = TimeSpan.Parse(request.Time),
                Active = true,
                Customer = new CustomerInfo
                {
                    FullName = request.Customer.FullName,
                    IdNumber = request.Customer.IdNumber,
                    ContactNumber = request.Customer.ContactNumber,
                    Email = request.Customer.Email,
                    Notes = request.Customer.Notes
                }
            };

            dbContext.AppointmentRequest.Add(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
            return new AppointmentResponse
            {
                appointmentId = entity.Id,
                referenceNumber = entity.ReferenceNumber,
                branchId = entity.BranchId,
                date = entity.Date.ToDateTime(TimeOnly.MinValue),
                time = entity.Time,
                status = "Confirmed",
                message = "Your appointment has been successfully booked! A confirmation has been sent to your phone and email."
            };

        }

        public async Task<bool> CancelAppointmentAsync(string referenceNumber,CancellationToken ct)
        {
            var rows = await dbContext.AppointmentRequest
                        .Where(a => a.ReferenceNumber == referenceNumber && a.Active)
                        .ExecuteUpdateAsync(s => s.SetProperty(a => a.Active, false));

            return rows > 0;
        }

        public async Task<AppointmentRequest> LookupAppointmentAsync(string idNumber, CancellationToken cancellationToken)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var future = today.AddDays(30);

            return await dbContext.AppointmentRequest
                    .Where(a => a.Customer.IdNumber == idNumber &&
                                a.Date >= today &&
                                a.Date < future &&
                                a.Active == true)
                    .FirstOrDefaultAsync(cancellationToken);
        }
    }



}
