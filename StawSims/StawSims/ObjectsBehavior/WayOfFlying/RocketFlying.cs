using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.DuckBehavior.WayOfFlying
{
    public class RocketFlying : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Mam rakietę! I jej używam...");
        }
    }
}
