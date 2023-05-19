using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.DuckBehavior.WayOfSound
{
    public class Squeak : ISound
    {
        public void Sound()
        {
            Console.WriteLine("pi pi pi");
        }
    }
}
