using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.DuckBehavior.WayOfSound
{
    internal class Quack : ISound
    {
        public void Sound()
        {
            Console.WriteLine("kwa kwa kwa");
        }
    }
}
