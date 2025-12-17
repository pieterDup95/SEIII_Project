using Microsoft.EntityFrameworkCore;

namespace appointment_service.Persistence
{
    public class ApplicationDbContextInitializer
    {
        private readonly ILogger<ApplicationDbContextInitializer> _logger;
        private readonly  ApplicationDbContext _context;

        public ApplicationDbContextInitializer(ILogger<ApplicationDbContextInitializer> logger,  ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task InitialiseAsync()
        {
            try
            {
                _logger.LogDebug("AppdbContext migrate started ");
                await _context.Database.MigrateAsync();
                _logger.LogDebug("AppdbContext migrate done");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while init the db.");
                throw;
            }
        }
    }
}
