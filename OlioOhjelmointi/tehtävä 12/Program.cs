﻿using System;
using System.Collections.Generic;
namespace tehtävä_12
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {

                pakka.Add("Hertta - " + (i + 1));
                pakka.Add("Pata - " + (i + 1));
                pakka.Add("Risti- " + (i + 1));
                pakka.Add("Ruutu - " + (i + 1));
            }
            foreach (string kortti in pakka)
            {

                Console.WriteLine(kortti);
            }
            Shuffle();
            
        }
        private static Random rnd = new Random();
        public static void Shuffle()
        {
            rnd.Next(1, 100);
        }
    }
}

    



