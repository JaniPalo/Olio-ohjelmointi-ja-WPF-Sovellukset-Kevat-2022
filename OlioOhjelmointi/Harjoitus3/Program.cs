using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 50, 20); 

            harvia.NäytäTiedot(); // Tulostetaan kiukaan tiedot
            harvia.Tila = true; // laitetaan kiuas päälle
            harvia.NäytäTiedot(); 
            harvia.SäädäLämpötila(30); // Muutetaan  lämpötilaa
            harvia.SäädäKosteutta(10); // Muutetaan kosteutta
            harvia.NäytäTiedot(); 
            harvia.Tila = false; // laitetaan kiuas pois päältä
        }
    }
}