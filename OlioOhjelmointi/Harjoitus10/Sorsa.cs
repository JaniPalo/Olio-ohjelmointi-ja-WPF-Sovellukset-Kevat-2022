using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Sorsa : Animal, ICanSwim, IIcanFly
    {
        public Sorsa(float swimSpeed, float wingSize)
        {
            SwimSpeed = swimSpeed;
            WingSize = wingSize;
        }

        public float SwimSpeed { get; set; 
        }

        

        public float WingSize { get; set; }
        public void Fly()
        {
            Console.WriteLine("Sorsa lentää. Siipien koko: " + WingSize);
        }
        public void Swim()
        {
            Console.WriteLine("Sorsa ui. nopeus on " + SwimSpeed);
        }
        public override void MakeASound()
        {
            Console.WriteLine("quack quack");
        }
    }
}

