using appointment_service.Models;
using appointment_service.Service.Models;

namespace appointment_service.Configuration;

public static class NotificationConfiguration
{
    public static WebApplicationBuilder AddNotifications(this WebApplicationBuilder builder)
    {
        var emailSettings = builder.Configuration.GetSection("EmailSettings").Get<EmailSettings>()
            ?? throw new InvalidOperationException("EmailSettings missing");

        var sqsSettings = builder.Configuration.GetSection("AWSSqs").Get<AWSSqsSettings>()
            ?? throw new InvalidOperationException("AWSSqs missing");

        builder.Services.AddSingleton(emailSettings);
        builder.Services.AddSingleton(sqsSettings);

        return builder;
    }
}