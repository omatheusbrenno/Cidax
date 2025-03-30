using System.Drawing;

namespace Cidax.Communication.Requests
{
    public class RequestRegisterLocationJson
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
