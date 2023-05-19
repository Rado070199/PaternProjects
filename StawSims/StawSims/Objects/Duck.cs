using StawSims.DuckBehavior.WayOfFlying;
using StawSims.DuckBehavior.WayOfSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StawSims.Ducks
{
    public abstract class Duck
    {
        private IFly _fly;
        private ISound _sound;

        protected Duck(IFly fly, ISound sound)
        {
            _fly = fly;
            _sound = sound;
        }

        public abstract void Display();
        public void MakeAFlight()
        {
            _fly.Fly();
        }
        public void MakeASound()
        {
            _sound.Sound();
        }
        public void SetFlyingIFly(IFly fly) 
        {
            _fly = fly;
        }
        public void Swim()
        {
            Console.WriteLine("Wszystkie kaczki pływają nawet te sztuczne");
        }
    }
}
