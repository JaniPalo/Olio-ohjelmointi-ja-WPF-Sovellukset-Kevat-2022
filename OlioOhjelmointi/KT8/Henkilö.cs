using System;
using System.Collections.Generic;
using System.Text;

namespace KT8
{
    abstract class Henkilö
    {
        public static int Instanssit = 0;

      

        public abstract void henkilöTiedot();
      
        public abstract void asiat();
        
      
        
        public Henkilö()
        {
            Instanssit++;
        }

        
        }
    }
