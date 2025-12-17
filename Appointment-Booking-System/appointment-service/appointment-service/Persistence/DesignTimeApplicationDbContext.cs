using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace appointment_service.Persistence
{
    public class DesignTimeApplicationDbContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {

            // Try current directory
            var currentDir = Directory.GetCurrentDirectory();
            var appSettingsPath = Path.Combine(currentDir, "appsettings.json");

            // If appsettings.json doesn't exist, try one level up
            if (!File.Exists(appSettingsPath))
            {
                currentDir = Path.Combine(currentDir, "appointment-service"); // fallback
                appSettingsPath = Path.Combine(currentDir, "appsettings.json");
            }

            var configuration = new ConfigurationBuilder()
                .SetBasePath(currentDir)
                .AddJsonFile("appsettings.Development.json", true, true)
                .Build();


            string readWriteConnectionString = configuration.GetValue<string>("Database:ConnectionString") ??
                                               throw new ArgumentNullException($"Database:ConnectionString");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql(readWriteConnectionString, builder =>
                builder.MigrationsHistoryTable("__EfMigrations", ApplicationDbContext.Schema));
            optionsBuilder.UseSnakeCaseNamingConvention();

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
