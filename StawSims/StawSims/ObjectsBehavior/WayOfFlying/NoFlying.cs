using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.DuckBehavior.WayOfFlying
{
    public class NoFlying : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Nie latam!");
        }
    }
}
