using System;
using System.Collections.Generic;
using System.Text;

namespace KT8
{
    class Työntekijä : Henkilö
    {
        public int ViikottaisetTunnit;
        public static int Instanssit;

        string Nimi;
        float Palkka;
        string Työpaikka;



        public Työntekijä(int viikottaisetTunnit)
        {
            ViikottaisetTunnit = viikottaisetTunnit;

            Instanssit++;
        }

        public Työntekijä(string nimi, float palkka, string työpaikka)
        {
            Nimi = nimi;
            Palkka = palkka;
            Työpaikka = työpaikka;
        }
        public override void asiat()
        {
            Console.WriteLine("Työntekijän viikottaiset tunnit: " + ViikottaisetTunnit);
            Console.WriteLine("Työntekijöitä olemassa: " + Instanssit);

          
        }

        public override void henkilöTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Työpaikka: " + Työpaikka);
            Console.WriteLine("Palkka: " + Palkka);
        }
    }
}
