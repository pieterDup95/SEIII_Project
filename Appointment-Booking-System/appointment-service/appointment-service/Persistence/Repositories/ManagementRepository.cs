using appointment_service.Controllers.Models;
using appointment_service.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace appointment_service.Persistence.Repositories
{
    public class ManagementRepository : IManagementRepository
    {

        private readonly ApplicationDbContext dbContext;

        public ManagementRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }


        public async Task<BranchDto?> CreateBranchAsync(CreateBranchDto createDto, CancellationToken cancellationToken)
        {
            // 1. Create branch entity
            var branch = new Branch
            {
                Id = Guid.NewGuid(),
                BranchName = createDto.BranchName,
                BranchCode = createDto.BranchCode,
                Provice = createDto.Provice,
                City = createDto.City,
                Suburb = createDto.Suburb,
                Address = createDto.Address,
                SlotPerHour = createDto.SlotPerHour
            };

            dbContext.Branches.Add(branch);

            // 2. Create operational hours (if provided)
            var operationalHoursList = createDto.OperationalHours?.Select(ohDto => new OperationalHours
            {
                Id = Guid.NewGuid(),
                BranchId = branch.Id,
                DayOfWeek = ohDto.DayOfWeek,
                OpenTime = ohDto.OpenTime,
                CloseTime = ohDto.CloseTime
            }).ToList();

            if (operationalHoursList != null)
            {
                dbContext.OperationalHours.AddRange(operationalHoursList);
            }

            // 3. Save changes
            await dbContext.SaveChangesAsync(cancellationToken);

            // 4. Return DTO
            return new BranchDto
            {
                Id = branch.Id,
                BranchName = branch.BranchName,
                BranchCode = branch.BranchCode,
                Provice = branch.Provice,
                City = branch.City,
                Suburb = branch.Suburb,
                Address = branch.Address,
                SlotPerHour = branch.SlotPerHour,
                OperationalHours = operationalHoursList?.Select(oh => new OperationalHoursDto
                {
                    DayOfWeek = oh.DayOfWeek,
                    OpenTime = oh.OpenTime,
                    CloseTime = oh.CloseTime
                }).ToList()
            };
        }

        public async Task<OperationalHoursDto?> CreateOperationalHoursAsync(CreateOperationalHoursDto dto, CancellationToken cancellationToken)
        {
            var entity = new OperationalHours
            {
                Id = Guid.NewGuid(),
                BranchId = dto.BranchId,
                DayOfWeek = dto.DayOfWeek,
                OpenTime = dto.OpenTime,
                CloseTime = dto.CloseTime
            };

            dbContext.OperationalHours.Add(entity);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new OperationalHoursDto
            {
                DayOfWeek = entity.DayOfWeek,
                OpenTime = entity.OpenTime,
                CloseTime = entity.CloseTime
            };
        }
    }
}
