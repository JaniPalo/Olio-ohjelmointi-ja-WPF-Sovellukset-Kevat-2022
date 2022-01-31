using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä4
{
    class Kappale
    {
        public string Nimi;
        public string Kesto;

        //tehdään kostruktori kappale luokan asioista
        public Kappale(string _nimi, string _kesto)
        {
            Nimi = _nimi;
            Kesto = _kesto;
        }
    }
}
