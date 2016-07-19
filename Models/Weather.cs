using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherForcastApp.Models
{
    public class Weather
    {
        public Object GetWeatherForcastByCityAndState(string city , string state)
        {
            if(city == null || state == null)
            {
                return null;
            }
            //return jsonContent
            string apiKey = "1d53ea7c0b4a3e80";
            string url = "http://api.wunderground.com/api/" + apiKey + "/geolookup/conditions/q/" + state + "/" + city + ".json";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
        public Object GetWeatherForcastDefault()
        {
            
            //return jsonContent
            string apiKey = "1d53ea7c0b4a3e80";
            string state = "Fl";
            string city = "Orlando";
            string url = "http://api.wunderground.com/api/" + apiKey + "/geolookup/conditions/q/" + state + "/" + city + ".json";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}