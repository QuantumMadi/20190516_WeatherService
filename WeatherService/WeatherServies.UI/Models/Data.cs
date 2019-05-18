using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherService.UI.Models
{
    [Serializable]
    public class Data
    {   
        [JsonProperty("request")]
        public List<Request> Request { get; set; }

        [JsonProperty("current_condition")]
        public List<CurrentCondition> Current { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather{ get; set; }
    }
}
