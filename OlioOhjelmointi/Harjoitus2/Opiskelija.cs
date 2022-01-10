using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        private string Nimi;
        private string OpiskelijaID;
        private int Opintopisteet;

        public  Opiskelija(string _nimi, string _OpiskelijaID, int _Opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _OpiskelijaID;
            Opintopisteet = _Opintopisteet;

        }
        public void TulostaData()
        {
            Console.WriteLine(Nimi + " ID: " + OpiskelijaID + " Opintopisteet: " + Opintopisteet);
        }

        public void MuokkaaOpintoPisteitä(int määrä)
        {
            Opintopisteet += määrä;
        }
    }
}
