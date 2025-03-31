using System.Drawing;

namespace Cidax.Communication.Requests
{
    public class RequestRegisterLocationJson
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
