// Services/SqsNotificationService.cs
using Amazon.SQS;
using Amazon.SQS.Model;
using appointment_service.Service.Events;
using appointment_service.Service.Interfaces;
using appointment_service.Service.Models;
using Microsoft.Extensions.Options;
using Serilog;
using System.Text.Json;

namespace appointment_service.Service
{
    public class SqsNotificationService : INotificationService
    {
        private readonly AmazonSQSClient _sqs;
        private readonly string _queueUrl;
        private readonly AWSSqsSettings _settings;

        public SqsNotificationService(AWSSqsSettings awssqsSettings)
        {
            _settings = awssqsSettings
                ?? throw new ArgumentNullException(nameof(awssqsSettings));

            if (string.IsNullOrWhiteSpace(_settings.QueueUrl))
                throw new InvalidOperationException("SQS QueueUrl is missing in configuration.");
            if (_settings.Region == null)
                throw new InvalidOperationException("SQS Region is missing in configuration.");

            _queueUrl = _settings.QueueUrl;

            var config = new AmazonSQSConfig
            {
                RegionEndpoint = _settings.RegionEndpoint
            };

            _sqs = new AmazonSQSClient(config);
        }

        public async Task SendAppointmentCreatedAsync(AppointmentCreatedEvent evt)
        {
            if (evt == null) throw new ArgumentNullException(nameof(evt));

            var messageBody = JsonSerializer.Serialize(evt, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            var request = new SendMessageRequest
            {
                QueueUrl = _queueUrl,
                MessageBody = messageBody,
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
                {
                    ["EventType"] = new MessageAttributeValue
                    {
                        DataType = "String",
                        StringValue = "AppointmentCreated"
                    },
                    ["ReferenceNumber"] = new MessageAttributeValue
                    {
                        DataType = "String",
                        StringValue = evt.AppointmentRef
                    }
                }
            };

            try
            {
                var response = await _sqs.SendMessageAsync(request);

                if (!response.HttpStatusCode.IsSuccess())
                {
                    Log.Information($"Failed to send SQS message: {response.HttpStatusCode}");
                }
            }
            catch (Exception ex)
            { 
                Log.Error($"SQS Send failed: {ex.Message}");
            }
        }
    }
     
    public static class HttpStatusCodeExtensions
    {
        public static bool IsSuccess(this System.Net.HttpStatusCode statusCode)
            => (int)statusCode >= 200 && (int)statusCode <= 299;
    }
}