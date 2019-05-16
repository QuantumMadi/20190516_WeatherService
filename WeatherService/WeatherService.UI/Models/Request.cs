using Newtonsoft.Json;
using System;

namespace WeatherService.UI.Models
{
    [Serializable]
    public class Request
    {   [JsonProperty("query")]
        public string CityName{ get; set; }
        [JsonProperty("type")]
        public string LocatioinType{ get; set; }
    }
}
