using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusAjoneuvo
{
    class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;


        public void DataTulostus()
        {
            Console.WriteLine(" Ajoneuvon malli: " + Nimi);
            Console.WriteLine(" Ajoneuvon nopeus: " + Nopeus);
            Console.WriteLine( " Ajoneuvon Renkaat:" + Renkaat);
        }
    }
}
