using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace APIpushnotifications.Web.NotificationHubs
{
    public class DeviceRegistration
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public MobilePlatform Platform { get; set; }
        public string Handle { get; set; }
        public string[] Tags { get; set; }
    }
}
