using appointment_service.Controllers.Models;

public interface IBranchDetailRepository
{
    Task<List<BranchDto>> GetAllBranchesAsync(string? search, CancellationToken cancellationToken);
    Task<BranchDto> GetBranchAsync(string branchId, CancellationToken cancellationToken);
    Task<List<TimeSpan>> GetAvailabilityAsync(string branchId, DateTime date, CancellationToken cancellationToken);
    Task<List<OperationalHoursDto>> GetAllOperationalHoursAsync(CancellationToken cancellationToken);
}