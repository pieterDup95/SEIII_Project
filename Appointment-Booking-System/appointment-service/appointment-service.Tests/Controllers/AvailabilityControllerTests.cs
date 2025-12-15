using appointment_service.Controllers;
using appointment_service.Controllers.Models;
using appointment_service.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;


namespace appointment_service.Tests.Controllers;
public class AvailabilityControllerTests
{
    private readonly Mock<IBranchDetailService> _serviceMock;
    private readonly Mock<ILogger<AvailabilityController>> _loggerMock;
    private readonly AvailabilityController _controller;

    public AvailabilityControllerTests()
    {
        _serviceMock = new Mock<IBranchDetailService>();
        _loggerMock = new Mock<ILogger<AvailabilityController>>();
        _controller = new AvailabilityController(_serviceMock.Object, _loggerMock.Object);
    }

    [Fact]
    public async Task GetAvailability_ReturnsOk_WhenDateIsValid()
    {
        // Arrange
        var branchId = "branch-123";
        var date = "2025-12-25";
        var parsedDate = DateTime.Parse(date);
        var response = new AvailabilityResponse
        {
            BranchId = Guid.NewGuid(),
            date = parsedDate,
            TimeSlots = new List<TimeSlot>()
        };
        _serviceMock.Setup(s => s.GetAvailabilityAsync(branchId, parsedDate, It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        // Act
        var result = await _controller.GetAvailability(branchId, date, CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(response, okResult.Value);
    }

    [Fact]
    public async Task GetAvailability_ReturnsBadRequest_WhenDateIsInvalid()
    {
        // Arrange
        var branchId = "branch-123";
        var invalidDate = "not-a-date";

        // Act
        var result = await _controller.GetAvailability(branchId, invalidDate, CancellationToken.None);

        // Assert
        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal("Invalid date format. Use YYYY-MM-DD", badRequest.Value);
    }

    [Fact]
    public async Task GetAvailability_CallsLogger()
    {
        // Arrange
        var branchId = "branch-123";
        var date = "2025-12-25";
        var parsedDate = DateTime.Parse(date);
        var response = new AvailabilityResponse
        {
            BranchId = Guid.NewGuid(),
            date = parsedDate,
            TimeSlots = new List<TimeSlot>()
        };
        _serviceMock.Setup(s => s.GetAvailabilityAsync(branchId, parsedDate, It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        // Act
        await _controller.GetAvailability(branchId, date, CancellationToken.None);

        // Assert
        _loggerMock.Verify(
            l => l.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Fetching availability for branch")),
                null,
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }
}