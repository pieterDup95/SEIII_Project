using appointment_service.Controllers.Models;
using appointment_service.Persistence.Repositories;
using appointment_service.Service;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace appointment_service.Tests.Services;

public class ManagementServiceTests
{
    private readonly Mock<ILogger<ManagementService>> _loggerMock;
    private readonly Mock<IManagementRepository> _repoMock;
    private readonly ManagementService _service;

    public ManagementServiceTests()
    {
        _loggerMock = new Mock<ILogger<ManagementService>>();
        _repoMock = new Mock<IManagementRepository>();
        _service = new ManagementService(_loggerMock.Object, _repoMock.Object);
    }

    [Fact]
    public async Task CreateBranchAsync_ReturnsBranchDto_WhenSuccessful()
    {
        var createDto = new CreateBranchDto
        {
            BranchName = "TestBranch",
            BranchCode = 1,
            Provice = "Province",
            City = "City",
            Suburb = "Suburb",
            Address = "Address",
            AppointmentsPerSlot = 2,
            SlotDuration = 30,
            OperationalHours = null
        };
        var branchDto = new BranchDto { Id = Guid.NewGuid(), BranchName = "TestBranch" };
        _repoMock.Setup(r => r.CreateBranchAsync(createDto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branchDto);

        var result = await _service.CreateBranchAsync(createDto, CancellationToken.None);

        Assert.Equal(branchDto, result);
    }

    [Fact]
    public async Task CreateBranchAsync_ReturnsNull_WhenRepositoryReturnsNull()
    {
        var createDto = new CreateBranchDto
        {
            BranchName = "TestBranch",
            BranchCode = 1,
            Provice = "Province",
            City = "City",
            Suburb = "Suburb",
            Address = "Address",
            AppointmentsPerSlot = 2,
            SlotDuration = 30,
            OperationalHours = null
        };
        _repoMock.Setup(r => r.CreateBranchAsync(createDto, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BranchDto?)null);

        var result = await _service.CreateBranchAsync(createDto, CancellationToken.None);

        Assert.Null(result);
    }

    [Fact]
    public async Task CreateOperationalHoursAsync_ReturnsOperationalHoursDto_WhenSuccessful()
    {
        var dto = new CreateOperationalHoursDto
        {
            BranchId = Guid.NewGuid(),
            DayOfWeek = DayOfWeek.Monday,
            OpenTime = new TimeSpan(8, 0, 0),
            CloseTime = new TimeSpan(17, 0, 0)
        };
        var opDto = new OperationalHoursDto
        {
            DayOfWeek = DayOfWeek.Monday,
            OpenTime = new TimeSpan(8, 0, 0),
            CloseTime = new TimeSpan(17, 0, 0)
        };
        _repoMock.Setup(r => r.CreateOperationalHoursAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(opDto);

        var result = await _service.CreateOperationalHoursAsync(dto, CancellationToken.None);

        Assert.Equal(opDto, result);
    }

    [Fact]
    public async Task CreateOperationalHoursAsync_ReturnsNull_WhenRepositoryReturnsNull()
    {
        var dto = new CreateOperationalHoursDto
        {
            BranchId = Guid.NewGuid(),
            DayOfWeek = DayOfWeek.Monday,
            OpenTime = new TimeSpan(8, 0, 0),
            CloseTime = new TimeSpan(17, 0, 0)
        };
        _repoMock.Setup(r => r.CreateOperationalHoursAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync((OperationalHoursDto?)null);

        var result = await _service.CreateOperationalHoursAsync(dto, CancellationToken.None);

        Assert.Null(result);
    }

    [Fact]
    public async Task AddBranchHolidayAsync_ReturnsTrue_WhenRepositoryReturnsTrue()
    {
        var branchId = Guid.NewGuid();
        var dto = new BranchHolidayDto { Date = "2025-12-25", Description = "Christmas" };
        _repoMock.Setup(r => r.AddBranchHolidayAsync(branchId, dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var result = await _service.AddBranchHolidayAsync(branchId, dto, CancellationToken.None);

        Assert.True(result);
    }

    [Fact]
    public async Task AddBranchHolidayAsync_ReturnsFalse_WhenRepositoryReturnsFalse()
    {
        var branchId = Guid.NewGuid();
        var dto = new BranchHolidayDto { Date = "2025-12-25", Description = "Christmas" };
        _repoMock.Setup(r => r.AddBranchHolidayAsync(branchId, dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _service.AddBranchHolidayAsync(branchId, dto, CancellationToken.None);

        Assert.False(result);
    }
}