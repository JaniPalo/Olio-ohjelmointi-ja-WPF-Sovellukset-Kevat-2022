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

        private List<Kappale> kappaleet = new List<Kappale>();

      
       

        public void Lisääkappale(Kappale kappale)
        {
            kappaleet.Add(kappale);
        }
 
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
