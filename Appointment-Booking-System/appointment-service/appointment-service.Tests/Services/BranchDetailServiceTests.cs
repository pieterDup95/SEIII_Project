using appointment_service.Controllers.Models;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace appointment_service.Tests.Services;
public class BranchDetailServiceTests
{
    private readonly Mock<IBranchDetailRepository> _repoMock;
    private readonly Mock<ILogger<BranchDetailService>> _loggerMock;
    private readonly BranchDetailService _service;

    public BranchDetailServiceTests()
    {
        _repoMock = new Mock<IBranchDetailRepository>();
        _loggerMock = new Mock<ILogger<BranchDetailService>>();
        _service = new BranchDetailService(_repoMock.Object, _loggerMock.Object);
    }

    [Fact]
    public async Task GetAllBranchesAsync_ReturnsBranches()
    {
        var branches = new List<BranchDto>
        {
            new BranchDto { Id = Guid.NewGuid(), BranchName = "Branch1" },
            new BranchDto { Id = Guid.NewGuid(), BranchName = "Branch2" }
        };
        _repoMock.Setup(r => r.GetAllBranchesAsync(null, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branches);

        var result = await _service.GetAllBranchesAsync(null, CancellationToken.None);

        Assert.Equal(branches, result);
    }

    [Fact]
    public async Task GetAllOperationalHoursAsync_ReturnsOperationalHours()
    {
        var hours = new List<OperationalHoursDto>
        {
            new OperationalHoursDto { DayOfWeek = DayOfWeek.Monday, OpenTime = new TimeSpan(8,0,0), CloseTime = new TimeSpan(17,0,0) }
        };
        _repoMock.Setup(r => r.GetAllOperationalHoursAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(hours);

        var result = await _service.GetAllOperationalHoursAsync(CancellationToken.None);

        Assert.Equal(hours, result);
    }

    [Fact]
    public async Task GetAvailabilityAsync_ReturnsAvailabilityResponse_WhenBranchAndHoursExist()
    {
        var branchId = Guid.NewGuid().ToString();
        var date = DateTime.Today;
        var branch = new BranchDto
        {
            Id = Guid.Parse(branchId),
            BranchName = "Branch1",
            AppointmentsPerSlot = 2,
            SlotDuration = 30,
            OperationalHours = new List<OperationalHoursDto>
            {
                new OperationalHoursDto { DayOfWeek = date.DayOfWeek, OpenTime = new TimeSpan(8,0,0), CloseTime = new TimeSpan(10,0,0) }
            }
        };
        var bookedTimes = new List<TimeSpan> { new TimeSpan(8, 0, 0) };

        _repoMock.Setup(r => r.GetBranchAsync(branchId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branch);
        _repoMock.Setup(r => r.GetAvailabilityAsync(branchId, date, It.IsAny<CancellationToken>()))
            .ReturnsAsync(bookedTimes);

        var result = await _service.GetAvailabilityAsync(branchId, date, CancellationToken.None);

        Assert.Equal(branch.Id, result.BranchId);
        Assert.Equal(date.Date, result.date);
        Assert.NotNull(result.TimeSlots);
        Assert.All(result.TimeSlots, ts => Assert.False(string.IsNullOrEmpty(ts.Time)));
    }

    [Fact]
    public async Task GetAvailabilityAsync_ReturnsEmptySlots_WhenNoOperationalHours()
    {
        var branchId = Guid.NewGuid().ToString();
        var date = DateTime.Today;
        var branch = new BranchDto
        {
            Id = Guid.Parse(branchId),
            BranchName = "Branch1",
            AppointmentsPerSlot = 2,
            SlotDuration = 30,
            OperationalHours = new List<OperationalHoursDto>() // No hours for the day
        };

        _repoMock.Setup(r => r.GetBranchAsync(branchId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branch);

        var result = await _service.GetAvailabilityAsync(branchId, date, CancellationToken.None);

        Assert.Equal(branch.Id, result.BranchId);
        Assert.Empty(result.TimeSlots);
    }

    [Fact]
    public async Task GetAvailabilityAsync_Throws_WhenBranchNotFound()
    {
        var branchId = Guid.NewGuid().ToString();
        var date = DateTime.Today;
        _repoMock.Setup(r => r.GetBranchAsync(branchId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BranchDto)null!);

        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            _service.GetAvailabilityAsync(branchId, date, CancellationToken.None));
    }

    [Fact]
    public async Task GetAvailabilityAsync_Throws_WhenBranchIdInvalid()
    {
        var branchId = "not-a-guid";
        var date = DateTime.Today;
        var branch = new BranchDto
        {
            Id = Guid.NewGuid(),
            BranchName = "Branch1",
            AppointmentsPerSlot = 2,
            SlotDuration = 30,
            OperationalHours = new List<OperationalHoursDto>()
        };
        _repoMock.Setup(r => r.GetBranchAsync(branchId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(branch);

        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            _service.GetAvailabilityAsync(branchId, date, CancellationToken.None));
    }

    [Fact]
    public async Task GetAvailabilityAsync_LogsError_OnException()
    {
        var branchId = Guid.NewGuid().ToString();
        var date = DateTime.Today;
        _repoMock.Setup(r => r.GetBranchAsync(branchId, It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception("DB error"));

        await Assert.ThrowsAsync<Exception>(() =>
            _service.GetAvailabilityAsync(branchId, date, CancellationToken.None));

        _loggerMock.Verify(
            l => l.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Error fetching availability for branch")),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            ),
            Times.Once
        );
    }
}