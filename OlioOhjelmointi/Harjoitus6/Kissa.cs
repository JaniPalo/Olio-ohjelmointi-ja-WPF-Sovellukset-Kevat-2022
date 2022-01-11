using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Kissa : Eläin
    {

        public string Väri;
        public int Ikä;

        public static int Instanssit = 0;

        public Kissa(string Väri, int ikä)
        {
            Väri = Väri;
            Ikä = ikä;


            Instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja olemassa: "  + Instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Meow MEow Mau");
        }
    }
}