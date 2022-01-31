using System;
using System.Collections.Generic;
using System.Text;

namespace KT8
{
    abstract class Henkilö
    {
        public static int Instanssit = 0;


        //Tehdään abstracti luokka jonka avulla voidaan ylitallentaa eli overridata se
        public abstract void henkilöTiedot();
      
        public abstract void asiat();
        
      
        //tehdään instanssi eli voidaan lisätä useita henkilöitä
        public Henkilö()
        {
            Instanssit++;
        }

        
        }
    }
