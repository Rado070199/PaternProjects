using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Panels
{
    public class CurrentWeatherPanel : IObserver, IInformationPanel
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherData weatherData;

        public CurrentWeatherPanel(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterFollower(this);
        }
        public void Display()
        {
            Console.WriteLine("Warunki bieżące -> temperatura:" + temperature + " stopni C, wilgotność:" + humidity + "%, ciśnienie:" + pressure + "Hp.");
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = (float)Math.Round(temperature, 1);
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
