using appointment_service.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

public interface IBranchDetailService
{
    Task<List<BranchDto>> GetAllBranchesAsync(string? search, CancellationToken cancellationToken);
    Task<AvailabilityResponse> GetAvailabilityAsync(string branchId, [FromQuery] DateTime date, CancellationToken cancellationToken);
    Task<List<OperationalHoursDto>> GetAllOperationalHoursAsync(CancellationToken cancellationToken);
}