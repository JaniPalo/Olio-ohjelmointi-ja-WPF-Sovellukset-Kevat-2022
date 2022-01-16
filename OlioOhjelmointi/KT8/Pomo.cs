using System;
using System.Collections.Generic;
using System.Text;

namespace KT8
{
    class Pomo : Henkilö
    {

        public string Auto;
        public float Bonus;
        public static int Instanssit = 1;

        string Nimi;
        float Palkka;
        string Työpaikka;

        public Pomo(string auto, float bonus)
        {
            Auto = auto;
            Bonus = bonus;


            Instanssit = 1;
        }
        public Pomo(string nimi, float palkka, string työpaikka)
        {
            Nimi = nimi;
            Palkka = palkka;
            Työpaikka = työpaikka;
        }
        public override void asiat()
        {
            Console.WriteLine("Pomo ajaa: " + Auto + " merkkisellä autolla");
            Console.WriteLine("Pomo saa: " + Bonus + " % boonusta");
            Console.WriteLine("Pomoja olemassa: " + Instanssit);
        }

        
        public override void henkilöTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Työpaikka: " + Työpaikka);
            Console.WriteLine("Palkka: " + Palkka);
        }
    }
}

