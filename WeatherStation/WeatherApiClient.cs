using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherApiClient
    {
        private string apiKey;

        public WeatherApiClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public WeatherData GetWeatherData(double latitude, double longitude)
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}", latitude, longitude, apiKey);

            WebClient web = new WebClient();
            var json = web.DownloadString(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            float temperature = jsonObj.main.temp - 273.15f;
            float humidity = jsonObj.main.humidity;
            float pressure = jsonObj.main.pressure;

            WeatherData weatherData = new WeatherData();
            weatherData.SetReading(temperature, humidity, pressure);

            return weatherData;
        }
    }

}
