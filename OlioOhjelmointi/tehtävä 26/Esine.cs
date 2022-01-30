using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_26
{
    class Esine
    {
        string Esineet;
        string Hinta;
        string Alkuperämaa;
        string Materiaali;

        public Esine(string esineet, string hinta, string alkuperämaa, string materiaali)
        {
            Esineet = esineet;
            Hinta = hinta;
            Alkuperämaa = alkuperämaa;
            Materiaali = materiaali;
           
        }

        public string esineet { get => Esineet; set => Esineet = value; }
        public string hinta { get => Hinta; set =>Hinta = value; }
        public string alkuperämaa { get => Alkuperämaa; set => Alkuperämaa = value; }
        public string materiaali { get => Materiaali; set => Materiaali = value; }
       
    }
}
