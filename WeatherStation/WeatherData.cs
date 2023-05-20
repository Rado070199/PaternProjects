using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Panels;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyFollowers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterFollower(IObserver o)
        {
            observers.Add(o);
        }

        public void UnregisterFollower(IObserver o)
        {
            observers.Remove(o);
        }

        public void ReadingChanged()
        {
            NotifyFollowers();
        }
        public void SetReading(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            ReadingChanged();
        }
    }
}
