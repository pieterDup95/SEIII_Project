using appointment_service.Common.Exception;
using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;
using appointment_service.Persistence.Repositories;
using appointment_service.Service;
using appointment_service.Service.Events;
using appointment_service.Service.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace appointment_service.Tests.Services;

public class AppointmentServiceTests
{
    private readonly Mock<ILogger<AppointmentService>> _loggerMock;
    private readonly Mock<IAppointmentRepository> _repoMock;
    private readonly Mock<INotificationService> _notificationMock;
    private readonly AppointmentService _service;

    public AppointmentServiceTests()
    {
        _loggerMock = new Mock<ILogger<AppointmentService>>();
        _repoMock = new Mock<IAppointmentRepository>();
        _notificationMock = new Mock<INotificationService>();
        _service = new AppointmentService(_loggerMock.Object, _repoMock.Object, _notificationMock.Object);
    }

    [Fact]
    public async Task BookAppointmentAsync_ReturnsResponse_WhenNoDuplicate()
    {
        // Arrange
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "Branch",
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
        _repoMock.Setup(r => r.LookupAppointmentAsync("1234567890", It.IsAny<CancellationToken>()))
            .ReturnsAsync((AppointmentRequest?)null);

        var response = new AppointmentResponse
        {
            appointmentId = Guid.NewGuid(),
            referenceNumber = "REF123",
            branchId = request.BranchId,
            date = request.Date,
            time = TimeSpan.Parse("09:00"),
            status = "Booked"
        };
        _repoMock.Setup(r => r.BookAppointmentAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        _notificationMock.Setup(n => n.SendAppointmentCreatedAsync(It.IsAny<AppointmentCreatedEvent>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await _service.BookAppointmentAsync(request, CancellationToken.None);

        // Assert
        Assert.Equal(response, result);
        _repoMock.Verify(r => r.BookAppointmentAsync(request, It.IsAny<CancellationToken>()), Times.Once);
        _notificationMock.Verify(n => n.SendAppointmentCreatedAsync(It.IsAny<AppointmentCreatedEvent>()), Times.Once);
    }

    [Fact]
    public async Task BookAppointmentAsync_ThrowsDuplicateBookingException_WhenDuplicateExists()
    {
        // Arrange
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "Branch",
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
        var existing = new AppointmentRequest
        {
            Id = Guid.NewGuid(),
            ReferenceNumber = "REF999",
            BranchId = request.BranchId,
            Date = DateOnly.FromDateTime(request.Date),
            Time = TimeSpan.Parse("09:00"),
            Customer = new CustomerInfo(),
            Active = true,
            CreatedAt = DateTime.Now
        };
        _repoMock.Setup(r => r.LookupAppointmentAsync("1234567890", It.IsAny<CancellationToken>()))
            .ReturnsAsync(existing);

        // Act & Assert
        await Assert.ThrowsAsync<DuplicateBookingException>(() =>
            _service.BookAppointmentAsync(request, CancellationToken.None));
        _repoMock.Verify(r => r.BookAppointmentAsync(It.IsAny<CreateAppointmentRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        _notificationMock.Verify(n => n.SendAppointmentCreatedAsync(It.IsAny<AppointmentCreatedEvent>()), Times.Never);
    }

    [Fact]
    public async Task BookAppointmentAsync_ThrowsException_WhenRepositoryThrows()
    {
        // Arrange
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "Branch",
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
        _repoMock.Setup(r => r.LookupAppointmentAsync("1234567890", It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("DB error"));

        // Act & Assert
        await Assert.ThrowsAsync<Exception>(() =>
            _service.BookAppointmentAsync(request, CancellationToken.None));
    }

    [Fact]
    public async Task BookAppointmentAsync_ThrowsException_WhenBookingFails()
    {
        // Arrange
        var request = new CreateAppointmentRequest
        {
            BranchId = Guid.NewGuid(),
            BranchName = "Branch",
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
        _repoMock.Setup(r => r.LookupAppointmentAsync("1234567890", It.IsAny<CancellationToken>()))
            .ReturnsAsync((AppointmentRequest?)null);

        _repoMock.Setup(r => r.BookAppointmentAsync(request, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Booking failed"));

        // Act & Assert
        await Assert.ThrowsAsync<Exception>(() =>
            _service.BookAppointmentAsync(request, CancellationToken.None));
        _notificationMock.Verify(n => n.SendAppointmentCreatedAsync(It.IsAny<AppointmentCreatedEvent>()), Times.Never);
    }

    [Fact]
    public async Task CancelAppointmentAsync_ReturnsTrue_WhenCancelled()
    {
        // Arrange
        var referenceNumber = "REF123";
        _repoMock.Setup(r => r.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        // Act
        var result = await _service.CancelAppointmentAsync(referenceNumber, CancellationToken.None);

        // Assert
        Assert.True(result);
        _repoMock.Verify(r => r.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task CancelAppointmentAsync_ReturnsFalse_WhenNotCancelled()
    {
        // Arrange
        var referenceNumber = "REF123";
        _repoMock.Setup(r => r.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        // Act
        var result = await _service.CancelAppointmentAsync(referenceNumber, CancellationToken.None);

        // Assert
        Assert.False(result);
        _repoMock.Verify(r => r.CancelAppointmentAsync(referenceNumber, It.IsAny<CancellationToken>()), Times.Once);
    }
}