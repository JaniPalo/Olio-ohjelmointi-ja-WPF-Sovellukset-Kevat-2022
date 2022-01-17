using System;
using System.Collections.Generic;
using System.Text;

namespace tehtävä11
{
    class Opiskelija
    {
        public string Etunimi;
        public string Sukunimi;
        public string Ryhmätunnus;
        public int OpiskelijaNumero;

        public void TulostaData()
        {
            Console.WriteLine("Opiskelija: {0} {1}. Ryhmätunnus: {2}. OpiskelijaNumero: {3} ",Etunimi,Sukunimi,Ryhmätunnus,OpiskelijaNumero);
            
        }
    }
}
