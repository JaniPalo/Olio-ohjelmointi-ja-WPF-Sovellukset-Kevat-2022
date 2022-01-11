using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Koira : Eläin
    {

        public string Rotu;
        public int Ikä;

        public static int Instanssit = 0;

        public Koira(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;


            Instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria on elossa : " + Instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof WOof WOOf");
        }
    }
}
