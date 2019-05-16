using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.UI.Models;
using Newtonsoft.Json;
using System.Net;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string om;
            using (var client = new WebClient())
            {
               om =  client.DownloadString("http://api.worldweatheronline.com/premium/v1/weather.ashx?key=5a9373434dec44b4819181647191605&q=London&format=json&num_of_days=7");
            }
            RootObject rootObj= JsonConvert.DeserializeObject<RootObject>(om);
         
            Console.ReadLine();
        }
    }
}
