using Newtonsoft.Json;
using System;

namespace WeatherService.UI.Models
{
    [Serializable]
    public class Weather
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("maxtempC")]
        public string MaxTemp { get; set; }
        [JsonProperty("mintempC")]
        public string MinTemp { get; set; }        
    }
}
