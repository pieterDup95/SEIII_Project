using Amazon.RDS.Util;
using Amazon.SQS;
using appointment_service.Controllers.Models;
using appointment_service.Models;
using appointment_service.Persistence;
using appointment_service.Persistence.Repositories;
using appointment_service.Service;
using appointment_service.Service.Interfaces;
using appointment_service.Service.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Serilog;


namespace appointment_service.Configuration
{
    public static class DatabaseConfiguration
    {
        public static WebApplicationBuilder ConfigureDatabase(this WebApplicationBuilder builder)
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            builder.ConfigureDbContexts();
            return builder;

        }

        private static WebApplicationBuilder ConfigureDbContexts(this WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;
             
            string connectionString = configuration.GetValue<string>("Database:ConnectionString") ??
                throw new ArgumentNullException($"Database:ConnectionString");

            Log.Information("connectionString: {ConnectionString}", connectionString);

            var dataSourceBuilder = CreateDataSourceBuilder(connectionString, builder).Build();

            builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(dataSourceBuilder, optionsBuilder
                    => optionsBuilder.MigrationsHistoryTable("__EfMigrations", ApplicationDbContext.Schema));
                options.EnableServiceProviderCaching();
                options.UseSnakeCaseNamingConvention();
            });

            builder.Services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>());

            return builder;
        }

        private static NpgsqlDataSourceBuilder CreateDataSourceBuilder(string connectionString, WebApplicationBuilder builder)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
             

            return dataSourceBuilder;
        }
    }
}
