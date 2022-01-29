using System;
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

        }



         Random rng = new Random();

         public void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

       
    }
}

