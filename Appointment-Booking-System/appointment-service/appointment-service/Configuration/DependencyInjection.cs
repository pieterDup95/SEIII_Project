using appointment_service.Persistence;
using appointment_service.Persistence.Repositories;
using appointment_service.Service;
using appointment_service.Service.Interfaces;

namespace appointment_service.Configuration;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
    {
        // Repositories
        builder.Services.AddScoped<IManagementRepository, ManagementRepository>();
        builder.Services.AddScoped<IBranchDetailRepository, BranchDetailRepository>();
        builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();

        // Services
        builder.Services.AddScoped<IManagementService, ManagementService>();
        builder.Services.AddScoped<IBranchDetailService, BranchDetailService>();
        builder.Services.AddScoped<IAppointmentService, AppointmentService>();

        // Notification services
        builder.Services.AddScoped<EmailNotificationService>();
        builder.Services.AddScoped<SqsNotificationService>();
        builder.Services.AddScoped<INotificationService, CompositeNotificationService>();

        // Initializers
        builder.Services.AddScoped<ApplicationDbContextInitializer>();

        return builder;
    }
}