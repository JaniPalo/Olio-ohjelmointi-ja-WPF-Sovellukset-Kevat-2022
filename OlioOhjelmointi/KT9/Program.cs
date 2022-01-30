using System;

namespace KT9
{
   abstract class Program
    {
        static void Main(string[] args)
        {


            
            float Taajuus;
            int Äänenvoimakkuus;


            Radio annettutaajuus = new Radio();
            Radio äänenvoimakkuus = new Radio();
            Console.WriteLine("Voit poistua kirjoittamalla 'poistu' ");
            while (true)
            {
                Console.WriteLine("Vaihda äänenvoimakkuutta (0-9)");
                string annettuVoimakkuus = Console.ReadLine();
                Console.WriteLine("KANAVAT ");
                Console.WriteLine("- Iskelmä: 88 ");
                Console.WriteLine("- Radio Nova : 104 ");
                Console.WriteLine("- Suomi pop : 105 ");
                Console.WriteLine("- Suomi Rock : 90 ");
                Console.WriteLine("- Nostalgia : 103");
                Console.WriteLine("Anna taajuus 88.0 ja 107.9 väliltä, Käytä , pilkkua");
                string annettuTaajuus = Console.ReadLine();
                if (annettuTaajuus.Equals("poistu"))
                {
                    break;
                }

                bool loppu = int.TryParse(annettuVoimakkuus, out Äänenvoimakkuus);
                if (loppu)
                {
                    äänenvoimakkuus.ÄänenVoimakkuus = Äänenvoimakkuus;

                }
                Console.WriteLine( "");

                if (annettuVoimakkuus.Equals("poistu"))
                {
                    break;
                }

                bool tulos = float.TryParse(annettuTaajuus, out Taajuus);

                if (tulos)
                {
                    annettutaajuus.AnnettuTaajuus = (float)Taajuus;
                    
                }
                else
                {
                    Console.WriteLine("Annettu arvo virheellinen, Voit sammuttaa kirjoittamalla poistu");
                }
            }
            Console.WriteLine("Radio sammutettu");
        }
        
    }
}
