using appointment_service.Models;
using appointment_service.Service.Events;
using appointment_service.Service.Interfaces;
using appointment_service.Service.Models;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.Ocsp;
using SendGrid;
using SendGrid.Helpers.Mail;
using Serilog;

namespace appointment_service.Service
{
    public class EmailNotificationService : INotificationService
    {
        private readonly EmailSettings _emailSettings;
        private readonly FrontendSettings _frontendSettings;
        public EmailNotificationService(EmailSettings emailSettings, FrontendSettings frontendSettings)
        {
            _emailSettings = emailSettings;
            _frontendSettings = frontendSettings;
        }

        public async Task SendAppointmentCreatedAsync(AppointmentCreatedEvent evt)
        {
            var client = new SendGridClient(_emailSettings.SendGridApiKey);
            var cancelUrl = $"{_frontendSettings.BaseUrl}/Appointments/cancel/{evt.AppointmentRef}";

            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_emailSettings.FromEmail, _emailSettings.FromName),
                Subject = $"Appointment Confirmed – {evt.AppointmentRef}"
            };

            msg.AddTo(new EmailAddress(evt.CustomerEmail));

            msg.HtmlContent = $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Appointment Confirmed</title>
                <style>
                    body {{ margin:0; padding:0; background:#f4f7fa; font-family: 'Segoe UI', Arial, sans-serif; }}
                    .container {{ max-width: 600px; margin: 20px auto; background: white; border-radius: 16px; overflow: hidden; box-shadow: 0 10px 40px rgba(0,0,0,0.1); }}
                    .header {{ background: linear-gradient(135deg, #0B1D41, #1e40af); padding: 40px 30px; text-align: center; color: white; }}
                    .header h1 {{ margin:0; font-size: 32px; font-weight: 900; letter-spacing: 1px; }}
                    .header p {{ margin: 8px 0 0; opacity: 0.9; font-size: 16px; }}
                    .content {{ padding: 40px 30px; color: #1f2937; }}
                    .ref {{ font-size: 28px; font-weight: 900; color: #1e40af; text-align: center; margin: 0 0 30px; letter-spacing: 2px; }}
                    .details {{ background: #f8fafc; border-radius: 12px; padding: 24px; margin: 24px 0; }}
                    .detail {{ display: flex; align-items: center; margin: 14px 0; font-size: 17px; }}
                    .icon {{ width: 40px; font-size: 22px; color: #1e40af; margin-right: 16px; }}
                    .btn {{ display: block; width: 280px; margin: 32px auto; padding: 16px; background: #facc15; color: #1e40af; text-align: center; text-decoration: none; font-weight: bold; font-size: 18px; border-radius: 12px; }}
                    .btn:hover {{ background: #fbbf24; }}
                    .cancel-btn {{ display: block; width: 320px; margin: 30px auto 10px; padding: 15px; background: #dc2626; color: white; text-align: center; text-decoration: none; font-weight: bold; font-size: 18px; border-radius: 12px; }}
                    .footer {{ background: #0B1D41; color: #e2e8f0; text-align: center; padding: 30px; font-size: 14px; }}
                    .highlight {{ color: #1e40af; font-weight: 600; }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>TheBank</h1>
                        <p>Your appointment is confirmed</p>
                    </div>

                    <div class='content'>
                        <p>Dear <strong>{evt.CustomerName.Split(' ')[0]}</strong>,</p>
                        <p>Thank you for choosing TheBank. Your appointment has been successfully booked.</p>

                        <div class='ref'>{evt.AppointmentRef}</div>

                        <div class='details'>
                            <div class='detail'>
                                <div class='icon'>[Location Icon]</div>
                                <div>
                                    <strong>Branch:</strong> {evt.Branch}<br> 
                                </div>
                            </div>
                            <div class='detail'>
                                <div class='icon'>[Calendar Icon]</div>
                                <div><strong>Date:</strong> {evt.Date:dddd, dd MMMM yyyy}</div>
                            </div>
                            <div class='detail'>
                                <div class='icon'>[Clock Icon]</div>
                                <div><strong>Time:</strong> {evt.Time}</div>
                            </div>
                        </div>

                        <p>We look forward to welcoming you. Please arrive 5–10 minutes early.</p>

                        <a href='{cancelUrl}' class='cancel-btn'>
                            Cancel Appointment
                        </a>

                        <p style='text-align:center; color:#64748b; font-size:15px; margin-top:20px;'>
                            To book a new appointment, please <strong>cancel this one first</strong> using the button above.
                        </p>

                        <a href='http://localhost:5173/book' class='btn'>
                            Book Another Appointment
                        </a>
                    </div>

                    <div class='footer'>
                        <p><strong>© 2025 TheBank</strong> • Established 2005 • South Africa</p>
                        <p>Need help? Call <strong>0800 123 456</strong> • <a href='mailto:support@thebank.co.za' style='color:#fbbf24;'>support@thebank.co.za</a></p>
                    </div>
                </div>
            </body>
            </html>";

            msg.SetClickTracking(true, true);
            msg.SetOpenTracking(true);

            try
            {
                var response = await client.SendEmailAsync(msg);

                if (!response.IsSuccessStatusCode)
                {
                    Log.Information($"SendGrid failed: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Email Send failed: {ex.Message}");
            }
        }
    }
}