using System;
using System.Collections.Generic;

namespace Harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIcanFly> lentoeläimet = new List<IIcanFly>(); 
            List<ICanSwim> Uimaeläimet = new List<ICanSwim>(); 

        CVaris varis1 = new CVaris(6);
            Sorsa sorsa1 = new Sorsa(5, 9);

            varis1.Fly();
            varis1.MakeASound();

            sorsa1.Fly();
            sorsa1.Swim();
            sorsa1.MakeASound();

            Console.WriteLine("Variksen tyyppi on " + varis1.GetType());


            lentoeläimet.Add(varis1);
            lentoeläimet.Add(sorsa1);

            Uimaeläimet.Add(sorsa1);

        }
    }
}
