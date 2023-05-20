using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ISubject
    {
        public void RegisterFollower(IObserver o);
        public void UnregisterFollower(IObserver o);
        public void NotifyFollowers();
    }
}
