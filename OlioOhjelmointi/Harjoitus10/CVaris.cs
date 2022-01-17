using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class CVaris : Animal, IIcanFly
    {
        public float WingSize { get; set; }
        public CVaris(float wingSize)

        {
            WingSize = wingSize;
        }

      

        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko: " + WingSize);       
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw kaaw");
        }
    }
}
