using StawSims.DuckBehavior.WayOfFlying;
using StawSims.DuckBehavior.WayOfSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.Ducks
{
    public class MallardDuck : ModelDuck
    {
        private static IFly _fly = new Flying();
        private static ISound _sound = new Quack();

        public MallardDuck() : base(_fly, _sound)
        {
        }
        public override void Display()
        {
            Console.WriteLine("Wyglądam jak kaczka krzyżóka");
        }
    }
}
