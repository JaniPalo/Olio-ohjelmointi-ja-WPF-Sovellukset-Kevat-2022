using System;
using System.Collections.Generic;
using System.Text;

namespace TestiApp
{
    class Koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public void TulostaData()
        {
            Console.WriteLine(" Koiran nimi: " + nimi + " Ikä: " + ikä + " Rotu: " + rotu);
        }

        public void Hauku()
        {
            Console.WriteLine("Woof Woof ");
        }
    }
}
