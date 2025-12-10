using Amazon;

namespace appointment_service.Service.Models
{
    public class AWSSqsSettings
    {
        public string Region { get; set; } = null!;
        public string QueueUrl { get; set; } = null!;

        public RegionEndpoint RegionEndpoint => RegionEndpoint.GetBySystemName(Region);
    }
}
