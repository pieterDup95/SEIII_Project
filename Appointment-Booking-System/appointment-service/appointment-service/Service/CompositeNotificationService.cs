using appointment_service.Service;
using appointment_service.Service.Events;
using appointment_service.Service.Interfaces;

public class CompositeNotificationService : INotificationService
{
    private readonly EmailNotificationService _emailService;
    private readonly SqsNotificationService _sqsService;

    public CompositeNotificationService(
        EmailNotificationService emailService,
        SqsNotificationService sqsService)
    {
        _emailService = emailService;
        _sqsService = sqsService;
    }

    public async Task SendAppointmentCreatedAsync(AppointmentCreatedEvent evt)
    {
        var tasks = new[]
        {
            _emailService.SendAppointmentCreatedAsync(evt),
            _sqsService.SendAppointmentCreatedAsync(evt)
        };

        await Task.WhenAll(tasks);
    }
}