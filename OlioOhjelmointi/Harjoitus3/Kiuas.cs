using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus3
{
    class Kiuas
    {
        private string Nimi;
        private int Lämpotila;
        private int Kosteus;
        public bool Tila = false;

        public Kiuas(string _nimi, int _lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpotila = _lämpötila;
            Kosteus = _kosteus;

        }
        public void NäytäTiedot()
        {
            if (Tila)
            {
                Console.WriteLine("Kiuas" + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpotila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else
            {
                Console.WriteLine("Kiuas" + " ei ole päällä");
            }
        }
        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpotila = uusiLämpötila;
        }
    }
}
