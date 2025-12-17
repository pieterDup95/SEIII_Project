using appointment_service.Controllers;
using appointment_service.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;


namespace appointment_service.Tests.Controllers;
public class BranchDetailControllerTests
{
    private readonly Mock<ILogger<BranchDetailController>> _loggerMock;
    private readonly Mock<IBranchDetailService> _serviceMock;
    private readonly BranchDetailController _controller;

    public BranchDetailControllerTests()
    {
        _loggerMock = new Mock<ILogger<BranchDetailController>>();
        _serviceMock = new Mock<IBranchDetailService>();
        _controller = new BranchDetailController(_loggerMock.Object, _serviceMock.Object);
    }

    [Fact]
    public async Task GetBranches_ReturnsOk_WithBranches()
    {
        // Arrange
        var branches = new List<BranchDto>
        {
            new BranchDto { Id = Guid.NewGuid(), BranchName = "Branch1", BranchCode = 1, Provice = "P", City = "C", Suburb = "S", Address = "A", ContactNumber = "123", SlotDuration = 15, AppointmentsPerSlot = 2, OperationalHours = null, PublicHolidays = new List<string>() }
        };
        _serviceMock.Setup(s => s.GetAllBranchesAsync(null, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branches);

        // Act
        var result = await _controller.GetBranches(null, CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(branches, okResult.Value);
    }

    [Fact]
    public async Task GetBranches_ReturnsOk_WithEmptyList()
    {
        // Arrange
        var branches = new List<BranchDto>();
        _serviceMock.Setup(s => s.GetAllBranchesAsync("search", It.IsAny<CancellationToken>()))
            .ReturnsAsync(branches);

        // Act
        var result = await _controller.GetBranches("search", CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(branches, okResult.Value);
    }

    [Fact]
    public async Task GetAllOperationalHours_ReturnsOk_WithHours()
    {
        // Arrange
        var hours = new List<OperationalHoursDto>
        {
            new OperationalHoursDto { DayOfWeek = DayOfWeek.Monday, OpenTime = new TimeSpan(8,0,0), CloseTime = new TimeSpan(17,0,0) }
        };
        _serviceMock.Setup(s => s.GetAllOperationalHoursAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(hours);

        // Act
        var result = await _controller.GetAllOperationalHours(CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(hours, okResult.Value);
    }

    [Fact]
    public async Task GetAllOperationalHours_ReturnsOk_WithEmptyList()
    {
        // Arrange
        var hours = new List<OperationalHoursDto>();
        _serviceMock.Setup(s => s.GetAllOperationalHoursAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(hours);

        // Act
        var result = await _controller.GetAllOperationalHours(CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(hours, okResult.Value);
    }
}