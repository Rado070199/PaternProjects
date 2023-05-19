using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.DuckBehavior.WayOfSound
{
    public class NoSound : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Nie wydaje dźwięku");
        }
    }
}
