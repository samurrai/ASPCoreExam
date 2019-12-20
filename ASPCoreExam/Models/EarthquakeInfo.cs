using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASPCoreExam.Models
{
    [JsonObject("feature")]
    public class EarthquakeInfo
    {
        public string Place { get; set; }
        [JsonPropertyName("mag")]
        public string Magnitude { get; set; }
    }
}
