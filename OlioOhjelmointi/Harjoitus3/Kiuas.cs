using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3__KT_
{
    class Kiuas
    {
        
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;

        public bool Tila = false;

        // Kiukaan konstruktori
        public Kiuas(string _nimi, int _lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpötila = _lämpötila;
            Kosteus = _kosteus;
        }

        // Näytetään kiukaan tiedot
        public void NäytäTiedot()
        {
            
            if (Tila) 
            {
                // tulostetaan kiukaan kaikki tiedot
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else
            {
                // tulostetaan viesti jos kiuas ei ole päällä
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }
        }

       
        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;
        }

       //muutetaan kosteutta
        public void SäädäKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
        }
    }
}