using appointment_service.Controllers.Models;

namespace appointment_service.Persistence.Repositories
{
    public interface IManagementRepository
    {

        Task<BranchDto?> CreateBranchAsync(CreateBranchDto createDto, CancellationToken cancellationToken);
        Task<OperationalHoursDto?> CreateOperationalHoursAsync(CreateOperationalHoursDto dto, CancellationToken cancellationToken);
    }
}
