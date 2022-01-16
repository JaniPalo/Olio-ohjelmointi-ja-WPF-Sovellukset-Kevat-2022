using System;
using System.Collections.Generic;
using System.Text;

namespace KT9
{
    public class Radio
    {

        public float value;

        public Radio(double _taajuus)
        {
            Taajuus = (float)_taajuus;
           
        }

        public Radio()
        {
        }

        private int äänenVoimakkuus;

        
        public int value1;

        public float Taajuus { get; private set; }

        private int annettuTaajuus;
        public float AnnettuTaajuus
        {
            get => annettuTaajuus;
            set

            {
                if (value > 107.9)
                {
                    Console.WriteLine("Taajuutta ei löytynyt ");
                    value= (float)107.9;
                }

                else if (value < 88.0)
                {
                    Console.WriteLine("Taajuutta ei löytynyt ");
                    value = (float)88.0;
                }
                Console.WriteLine("Taajuus on asetettu: " + value);
                Taajuus = value;
            }
        }
      
        public int ÄänenVoimakkuus
        {
            get => äänenVoimakkuus;
            set

            {
                if (value > 9)
                {
                    Console.WriteLine("Äänenvoimakkuus on liian suuri ");
                    value= 9;
                }

                else if (value < 0)
                {
                    Console.WriteLine("Äänet ovat poissa ");
                    value = 0;
                }
                Console.WriteLine("Äänenvoimakkuus on asetettu: "+ value);
                
            }
        }
    }
}