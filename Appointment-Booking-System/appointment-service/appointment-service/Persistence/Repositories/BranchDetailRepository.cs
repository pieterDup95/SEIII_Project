using appointment_service.Controllers.Models;
using appointment_service.Persistence;
using appointment_service.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class BranchDetailRepository : IBranchDetailRepository
{
    private readonly ApplicationDbContext dbContext;

    public BranchDetailRepository(ApplicationDbContext context)
    {
        dbContext = context;
    }

    public async Task<List<BranchDto>> GetAllBranchesAsync(string? search, CancellationToken cancellationToken)
    {

        var query = dbContext.Branches
               .Include(b => b.OperationalHours)
               .AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(b =>
                b.BranchName.ToLower().Contains(search) ||
                b.City.ToLower().Contains(search) ||
                b.Suburb.ToLower().Contains(search) ||
                b.Address.ToLower().Contains(search));
        }

        var branches = await query.ToListAsync(cancellationToken);

        return branches.Select(b => new BranchDto
        {
            Id = b.Id,
            BranchName = b.BranchName,
            BranchCode = b.BranchCode,
            Address = b.Address,
            ContactNumber = b.ContactNumber,
            City = b.City,
            Provice = b.Provice,
            Suburb = b.Suburb,
            SlotPerHour = b.SlotPerHour,
            OperationalHours = b.OperationalHours.Select(oh => new OperationalHoursDto
            {
                DayOfWeek = oh.DayOfWeek,
                OpenTime = oh.OpenTime,
                CloseTime = oh.CloseTime
            }).ToList()
        }).ToList();
    }


    public async Task<BranchDto> GetBranchAsync(string branchId, CancellationToken cancellationToken)
    {

        return await dbContext.Branches
                .Include(b => b.OperationalHours)
                .Where(b => b.Id.ToString() == branchId)
                .Select(b => new BranchDto
                {
                    Id = b.Id,
                    BranchName = b.BranchName,
                    BranchCode = b.BranchCode,
                    Address = b.Address,
                    City = b.City,
                    Provice = b.Provice,
                    Suburb = b.Suburb,
                    SlotPerHour = b.SlotPerHour,
                    OperationalHours = b.OperationalHours.Select(oh => new OperationalHoursDto
                    {
                        DayOfWeek = oh.DayOfWeek,
                        OpenTime = oh.OpenTime,
                        CloseTime = oh.CloseTime
                    }).ToList()
                })
                .FirstOrDefaultAsync(cancellationToken);
    }
    public async Task<List<TimeSpan>> GetAvailabilityAsync(string branchId, DateTime date, CancellationToken cancellationToken)
    {
        var selectedDate = date.Date;

        return await dbContext.AppointmentRequest
            .Where(a => a.BranchId.ToString() == branchId && a.Date.Date == selectedDate && a.Active == true)
            .Select(a => a.Time)
            .ToListAsync(cancellationToken);


    }


    public async Task<List<OperationalHoursDto>> GetAllOperationalHoursAsync(CancellationToken cancellationToken)
    {
        return await dbContext.OperationalHours
            .Select(c => new OperationalHoursDto
            {
                DayOfWeek = c.DayOfWeek,
                OpenTime = c.OpenTime,
                CloseTime = c.CloseTime
            })
            .ToListAsync(cancellationToken);
    }
}