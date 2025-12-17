using appointment_service.Controllers;
using appointment_service.Controllers.Models;
using appointment_service.Service.Interfaces;
using appointment_service.Common.Exception;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace appointment_service.Tests.Controllers;

public class AppointmentsControllerTests
{
    private readonly Mock<ILogger<AppointmentsController>> _loggerMock;
    private readonly Mock<IAppointmentService> _serviceMock;
    private readonly AppointmentsController _controller;

    public AppointmentsControllerTests()
    {
        _loggerMock = new Mock<ILogger<AppointmentsController>>();
        _serviceMock = new Mock<IAppointmentService>();
        _controller = new AppointmentsController(_loggerMock.Object, _serviceMock.Object);
    }

    [Fact]
    public async Task BookAppointment_ReturnsOk_WhenSuccessful()
    {
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "TestBranch",
            Date = DateTime.Today,
            Time = "09:00",
            Customer = new CustomerDto
            {
                FullName = "John Doe",
                IdNumber = "1234567890",
                ContactNumber = "0123456789",
                Email = "john@example.com"
            }
        };
        var response = new AppointmentResponse { appointmentId = Guid.NewGuid(), referenceNumber = "REF123" };
        _serviceMock.Setup(s => s.BookAppointmentAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        var result = await _controller.BookAppointment(request, CancellationToken.None);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(response, okResult.Value);
    }

    [Fact]
    public async Task BookAppointment_ReturnsConflict_OnDuplicateBooking()
    {
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "TestBranch",
            Date = DateTime.Today,
            Time = "09:00",
            Customer = new CustomerDto
            {
                FullName = "John Doe",
                IdNumber = "1234567890",
                ContactNumber = "0123456789",
                Email = "john@example.com"
            }
        };
        _serviceMock.Setup(s => s.BookAppointmentAsync(request, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new DuplicateBookingException("Duplicate booking"));

        var result = await _controller.BookAppointment(request, CancellationToken.None);

        var conflictResult = Assert.IsType<ConflictObjectResult>(result);
        var value = conflictResult.Value;
        var errorProperty = value.GetType().GetProperty("error");
        Assert.NotNull(errorProperty);
        Assert.Equal("DuplicateBooking", errorProperty.GetValue(value));
    }

    [Fact]
    public async Task BookAppointment_ReturnsServerError_OnException()
    {
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "TestBranch",
            Date = DateTime.Today,
            Time = "09:00",
            Customer = new CustomerDto
            {
                FullName = "John Doe",
                IdNumber = "1234567890",
                ContactNumber = "0123456789",
                Email = "john@example.com"
            }
        };
        _serviceMock.Setup(s => s.BookAppointmentAsync(request, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Unexpected error"));

        var result = await _controller.BookAppointment(request, CancellationToken.None);

        var serverError = Assert.IsType<ObjectResult>(result);
        var value = serverError.Value;
        var errorProperty = value.GetType().GetProperty("error");
        Assert.NotNull(errorProperty);
        Assert.Equal("ServerError", errorProperty.GetValue(value)); 
    }

    [Fact]
    public async Task CancelAppointment_ReturnsOk_WhenSuccessful()
    {
        var referenceNumber = "REF123";
        _serviceMock.Setup(s => s.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var result = await _controller.CancelAppointment(referenceNumber, CancellationToken.None);

        var okResult = Assert.IsType<OkObjectResult>(result);
        var value = okResult.Value;
        var messageProperty = value.GetType().GetProperty("message");
        Assert.NotNull(messageProperty);
        Assert.Equal("Appointment cancelled successfully.", messageProperty.GetValue(value));
    }

    [Fact]
    public async Task CancelAppointment_ReturnsBadRequest_WhenReferenceNumberIsEmpty()
    {
        var result = await _controller.CancelAppointment("", CancellationToken.None);

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal("Reference number is required.", badRequest.Value);
    }

    [Fact]
    public async Task CancelAppointment_ReturnsNotFound_WhenNotCancelled()
    {
        var referenceNumber = "REF123";
        _serviceMock.Setup(s => s.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _controller.CancelAppointment(referenceNumber, CancellationToken.None);

        var notFound = Assert.IsType<NotFoundObjectResult>(result);
        var value = notFound.Value;
        var messageProperty = value.GetType().GetProperty("message");
        Assert.NotNull(messageProperty);
        Assert.Equal("Appointment not found or already cancelled.", messageProperty.GetValue(value));
    }

    [Fact]
    public async Task CancelAppointment_ReturnsServerError_OnException()
    {
        var referenceNumber = "REF123";
        _serviceMock.Setup(s => s.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Unexpected error"));

        var result = await _controller.CancelAppointment(referenceNumber, CancellationToken.None);

        var serverError = Assert.IsType<ObjectResult>(result);
        var value = serverError.Value;
        var errorProperty = value.GetType().GetProperty("error");
        Assert.NotNull(errorProperty);
        Assert.Equal("ServerError", errorProperty.GetValue(value));
    }
}