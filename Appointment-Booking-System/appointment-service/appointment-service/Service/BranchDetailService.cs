using appointment_service.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

public class BranchDetailService : IBranchDetailService
{
    private readonly IBranchDetailRepository _repository;
    private readonly ILogger<BranchDetailService> _logger;

    public BranchDetailService(IBranchDetailRepository repository, ILogger<BranchDetailService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public Task<List<BranchDto>> GetAllBranchesAsync(string? search, CancellationToken cancellationToken)
        => _repository.GetAllBranchesAsync(search, cancellationToken);

    public async Task<AvailabilityResponse>  GetAvailabilityAsync(string branchId, [FromQuery] DateTime date, CancellationToken cancellationToken)
    {
        try
        {
            var branch = await _repository.GetBranchAsync(branchId, cancellationToken)
                         ?? throw new InvalidOperationException("Branch not found");

            if (!Guid.TryParse(branchId, out var branchGuid))
                throw new InvalidOperationException("Invalid branch ID format");

            var dayHours = branch.OperationalHours
                .FirstOrDefault(h => h.DayOfWeek == date.DayOfWeek);

            if (dayHours == null)
            {
                return new AvailabilityResponse
                {
                    BranchId = branchGuid,
                    date = date.Date,
                    TimeSlots = Array.Empty<TimeSlot>()
                };
            }

            var bookedTimes = await _repository.GetAvailabilityAsync(branchId, date, cancellationToken); 
            var bookedCounts = bookedTimes
                .GroupBy(t => t)
                .ToDictionary(g => g.Key, g => g.Count());

            var slots = new List<TimeSlot>();
            var now = DateTime.Now;
            var isToday = date.Date == now.Date;

            var startTime = isToday
                ? new TimeSpan(now.Hour + 1, 0, 0)
                : dayHours.OpenTime;

            if (startTime < dayHours.OpenTime)
                startTime = dayHours.OpenTime;

            var current = startTime;

            while (current < dayHours.CloseTime)
            {
                var booked = bookedCounts.GetValueOrDefault(current, 0);
                var isAvailable = booked < branch.AppointmentsPerSlot;

                slots.Add(new TimeSlot(
                    Time: current.ToString(@"hh\:mm"),
                    IsAvailable: isAvailable
                ));

                current = current.Add(TimeSpan.FromMinutes(branch.SlotDuration));
            }

            return new AvailabilityResponse
            {
                BranchId = branchGuid,
                date = date.Date,
                TimeSlots = slots
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching availability for branch {BranchId} on date {Date}", branchId, date);
            throw;
        }
    }
     

    public Task<List<OperationalHoursDto>> GetAllOperationalHoursAsync(CancellationToken cancellationToken)
        => _repository.GetAllOperationalHoursAsync(cancellationToken);
}