using appointment_service.Controllers.Models;
using appointment_service.Persistence.Repositories;
using appointment_service.Service.Interfaces;

namespace appointment_service.Service
{
    public class ManagementService : IManagementService
    {
        private readonly ILogger<ManagementService> _logger;
        private readonly IManagementRepository _managementRepository;

        public ManagementService(ILogger<ManagementService> logger, IManagementRepository managementRepository)
        {
            _logger = logger;
            _managementRepository = managementRepository;
        }


        public async Task<BranchDto?> CreateBranchAsync(CreateBranchDto branchDto, CancellationToken cancellationToken)
        {
            var created = await _managementRepository.CreateBranchAsync(branchDto, cancellationToken);
            return created;
        }

        public async Task<OperationalHoursDto?> CreateOperationalHoursAsync(CreateOperationalHoursDto dto, CancellationToken cancellationToken)
        {
            return await _managementRepository.CreateOperationalHoursAsync(dto, cancellationToken);
        }
    }
}
