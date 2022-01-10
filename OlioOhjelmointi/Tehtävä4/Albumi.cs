using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä4
{
    class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public string Hinta;


        private List<Kappale> kappaleet = new List<Kappale>();


        public void Lisääkappale(Kappale kappale)
        {
            kappaleet.Add(kappale);
        }
 
        public void TulostaKappaleet()
        {
            foreach  (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ";" + kappale.Kesto);
            }
        }
    }
}
