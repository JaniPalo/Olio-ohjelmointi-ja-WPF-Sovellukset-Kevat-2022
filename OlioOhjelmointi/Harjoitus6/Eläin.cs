using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    abstract class Eläin
    {
        private static int Instanssit = 0;

        public Eläin()
        {
            Instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä olemassa: " + Instanssit);
        }

        public abstract void Ääntele();
    }
}
