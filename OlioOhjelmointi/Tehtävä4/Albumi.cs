using System;
using System.Collections.Generic;

namespace Tehtävä4
{
    class Albumi
    {
        public string Artisti = "Fleetwood mac";     
        public string Genre = "Rock";
        public int  Hinta = 20;
        public string Nimi = "Rumours";

        //Tehdään kappale luokasta lista, jota voidaan käyttää albumi luokan kanssa
        private List<Kappale> kappaleet = new List<Kappale>();

      
       
        //Tehdään metodi jolla voidaan kutsua kappaleen tiedot
        public void Lisääkappale(Kappale kappale)
        {
            kappaleet.Add(kappale);
        }

        //Tehdään metodi jolla voidaan kutsua tulostaa kappaleet foreach loopin avulla eli otetaan jokainen kappale kappale luokasta 
        public void TulostaKappaleet()
        {
            foreach  (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + " : " + kappale.Kesto);
            }
        }
        public void TulostaAlbumi()
        {
            Console.WriteLine("- Albumi: " + Nimi);
            Console.WriteLine("- Artisti: " + Artisti);
            Console.WriteLine("- Genre: " + Genre);
            Console.WriteLine("- Hinta: " + Hinta + " $ ");
        }
    }
}
