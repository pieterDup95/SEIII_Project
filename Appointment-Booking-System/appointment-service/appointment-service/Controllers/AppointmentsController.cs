
using appointment_service.Common.Exception;
using appointment_service.Controllers.Models;
using appointment_service.Persistence;
using appointment_service.Persistence.Entities;
using appointment_service.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appointment_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "frontend")]
    public class AppointmentsController : ControllerBase
    {

        private readonly ILogger<AppointmentsController> _logger;
        private readonly IAppointmentService _service;

        public AppointmentsController(ILogger<AppointmentsController> logger, IAppointmentService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("create")]
        public async Task<IActionResult> BookAppointment([FromBody] CreateAppointmentRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Received appointment booking request for ID Number: {IdNumber}", request.Customer.IdNumber);
                var appointment = await _service.BookAppointmentAsync(request, cancellationToken);
                return Ok(appointment);
            }
            catch (DuplicateBookingException ex)
            {
                return Conflict(new
                {
                    error = "DuplicateBooking",
                    message = ex.Message
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = "ServerError",
                    message = "An unexpected error occurred. Please try again later."
                });
            }
        }
        [HttpPost("cancel/{referenceNumber}")]
        public async Task<IActionResult> CancelAppointment(string referenceNumber, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Received appointment cancellation request for Reference Number: {ReferenceNumber}", referenceNumber);
                if (string.IsNullOrWhiteSpace(referenceNumber))
                    return BadRequest("Reference number is required.");

                var cancelled = await _service.CancelAppointmentAsync(referenceNumber, cancellationToken);

                if (!cancelled)
                    return NotFound(new { message = "Appointment not found or already cancelled." });

                return Ok(new { message = "Appointment cancelled successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = "ServerError",
                    message = "An unexpected error occurred. Please try again later."
                });
            }
        }
    }
}
