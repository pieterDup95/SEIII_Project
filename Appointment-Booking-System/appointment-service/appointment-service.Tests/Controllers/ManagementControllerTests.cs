using appointment_service.Controllers;
using appointment_service.Controllers.Models;
using appointment_service.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;


namespace appointment_service.Tests.Controllers;
public class ManagementControllerTests
{
    private readonly Mock<ILogger<ManagementController>> _loggerMock;
    private readonly Mock<IManagementService> _serviceMock;
    private readonly ManagementController _controller;

    public ManagementControllerTests()
    {
        _loggerMock = new Mock<ILogger<ManagementController>>();
        _serviceMock = new Mock<IManagementService>();
        _controller = new ManagementController(_loggerMock.Object, _serviceMock.Object);
    }

    [Fact]
    public async Task CreateBranch_ReturnsCreated_WhenSuccessful()
    {
        var createDto = new CreateBranchDto
        {
            BranchName = "Test",
            BranchCode = 1,
            Provice = "P",
            City = "C",
            Suburb = "S",
            Address = "A",
            AppointmentsPerSlot = 1,
            SlotDuration = 15,
            OperationalHours = null
        };
        var branchDto = new BranchDto();
        _serviceMock.Setup(s => s.CreateBranchAsync(createDto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branchDto);

        var result = await _controller.CreateBranch(createDto, CancellationToken.None);

        var createdResult = Assert.IsType<CreatedResult>(result);
        Assert.Equal(branchDto, createdResult.Value);
    }

    [Fact]
    public async Task CreateBranch_ReturnsBadRequest_WhenNullReturned()
    {
        var createDto = new CreateBranchDto
        {
            BranchName = "Test",
            BranchCode = 1,
            Provice = "P",
            City = "C",
            Suburb = "S",
            Address = "A",
            AppointmentsPerSlot = 1,
            SlotDuration = 15,
            OperationalHours = null
        };
        _serviceMock.Setup(s => s.CreateBranchAsync(createDto, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BranchDto?)null);

        var result = await _controller.CreateBranch(createDto, CancellationToken.None);

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequest.StatusCode);
    }

    [Fact]
    public async Task CreateBranch_ReturnsServerError_OnException()
    {
        var createDto = new CreateBranchDto();
        _serviceMock.Setup(s => s.CreateBranchAsync(It.IsAny<CreateBranchDto>(), It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Test exception"));

        var result = await _controller.CreateBranch(createDto, CancellationToken.None);

        var serverError = Assert.IsType<ObjectResult>(result);
        Assert.Equal(500, serverError.StatusCode);
    }

    [Fact]
    public async Task CreateOperationalHours_ReturnsCreated_WhenSuccessful()
    {
        var dto = new CreateOperationalHoursDto
        {
            BranchId = Guid.NewGuid(),
            DayOfWeek = DayOfWeek.Monday,
            OpenTime = new TimeSpan(8, 0, 0),
            CloseTime = new TimeSpan(17, 0, 0)
        };
        var opDto = new OperationalHoursDto();
        _serviceMock.Setup(s => s.CreateOperationalHoursAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(opDto);

        var result = await _controller.CreateOperationalHours(dto, CancellationToken.None);

        var createdResult = Assert.IsType<CreatedAtActionResult>(result);
        Assert.Equal(opDto, createdResult.Value);
    }

    [Fact]
    public async Task CreateOperationalHours_ReturnsBadRequest_WhenNullReturned()
    {
        var dto = new CreateOperationalHoursDto();
        _serviceMock.Setup(s => s.CreateOperationalHoursAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync((OperationalHoursDto?)null);

        var result = await _controller.CreateOperationalHours(dto, CancellationToken.None);

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequest.StatusCode);
    }

    [Fact]
    public async Task CreateOperationalHours_ReturnsServerError_OnException()
    {
        var dto = new CreateOperationalHoursDto();
        _serviceMock.Setup(s => s.CreateOperationalHoursAsync(It.IsAny<CreateOperationalHoursDto>(), It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Test exception"));

        var result = await _controller.CreateOperationalHours(dto, CancellationToken.None);

        var serverError = Assert.IsType<ObjectResult>(result);
        Assert.Equal(500, serverError.StatusCode);
    }

    [Fact]
    public async Task AddBranchHoliday_Returns201_WhenSuccessful()
    {
        var branchId = Guid.NewGuid();
        var dto = new BranchHolidayDto { Date = "2025-12-25", Description = "Christmas" };
        _serviceMock.Setup(s => s.AddBranchHolidayAsync(branchId, dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var result = await _controller.AddBranchHoliday(branchId, dto, CancellationToken.None);

        var statusResult = Assert.IsType<StatusCodeResult>(result);
        Assert.Equal(201, statusResult.StatusCode);
    }

    [Fact]
    public async Task AddBranchHoliday_ReturnsBadRequest_WhenFailed()
    {
        var branchId = Guid.NewGuid();
        var dto = new BranchHolidayDto { Date = "2025-12-25", Description = "Christmas" };
        _serviceMock.Setup(s => s.AddBranchHolidayAsync(branchId, dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _controller.AddBranchHoliday(branchId, dto, CancellationToken.None);

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequest.StatusCode);
    }

    [Fact]
    public async Task AddBranchHoliday_ReturnsServerError_OnException()
    {
        var branchId = Guid.NewGuid();
        var dto = new BranchHolidayDto { Date = "2025-12-25", Description = "Christmas" };
        _serviceMock.Setup(s => s.AddBranchHolidayAsync(branchId, dto, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("Test exception"));

        var result = await _controller.AddBranchHoliday(branchId, dto, CancellationToken.None);

        var serverError = Assert.IsType<ObjectResult>(result);
        Assert.Equal(500, serverError.StatusCode);
    }
}