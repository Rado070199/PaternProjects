using StawSims.DuckBehavior.WayOfFlying;
using StawSims.DuckBehavior.WayOfSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.Ducks
{
    public class ModelDuck : Duck
    {
        private static IFly _fly = new NoFlying();
        private static ISound _sound = new NoSound();

        public ModelDuck() : base(_fly, _sound)
        {
        }

        public ModelDuck(IFly _fly, ISound _sound) : base(_fly, _sound)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Jestem modelową kaczką");
        }
    }
}
