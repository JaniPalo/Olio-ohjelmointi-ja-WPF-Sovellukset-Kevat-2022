using System;
using System.Collections.Generic;
using System.Text;

namespace tehtävä_12
{
   public class Kortti
    {
       
        
            private string Numerot;
            private string KortinArvo;

            public Kortti(string KorttiNumero, string KorttiArvo)
            {
            Numerot = KorttiNumero;
            KortinArvo = KorttiArvo;
            }
        public override string ToString()
        {
            return Numerot + " " + KortinArvo;
        }
    }
  }


