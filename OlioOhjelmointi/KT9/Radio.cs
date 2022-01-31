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

        
        public float value1;

        public float Taajuus { get; private set; }

        private int annettuTaajuus;
        public float AnnettuTaajuus
        {
            get => annettuTaajuus;
            set

            {
               //jos annettutaajuus on ... niin syötetään konsoliin tiedot
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
                //kun taajuus osuu oikeaan kanavaan syötetään konsoliin tieto
                if (value == 88)
                {
                    Console.WriteLine("Iskelmä löytyi ");
                    value = (float)88;
                }

                if (value == 104)
                {
                    Console.WriteLine("Radio nova löytyi ");
                    value = (float)104;
                }
                if (value == 105)
                {
                    Console.WriteLine("Suomi pop löytyi ");
                    value = (float)105;
                }
                if (value == 90)
                {
                    Console.WriteLine("Suomi rock löytyi ");
                    value= (float)90;
                }
                if (value == 103)
                {
                    Console.WriteLine("Nostalgia löytyi ");
                    value = (float)103;
                }
            }
        }
      
        //luodaan uusi public int äänenvoikkuus jota käyttäjä voi muuttaa. jos antama arvo on suurempi tai pienempi laitetaan tieto konsolin
        //jos arvo ei mene ali eikä yli konsoliin asetetaan käyttäjän antama syöte
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