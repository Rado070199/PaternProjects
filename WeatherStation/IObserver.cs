using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IObserver
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}
