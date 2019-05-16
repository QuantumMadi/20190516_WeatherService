using Newtonsoft.Json;
using System;

namespace WeatherService.UI.Models
{
    [Serializable]
    public class CurrentCondition
    {
        [JsonProperty("temp_c")]
        public string CurrentTemp { get; set; }
        [JsonProperty("observation_time")]
        public string ObesrvationTime { get; set; }
    }
}
