using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 45;
            float b = 13;

           
            Console.WriteLine("Summa: " + Laskin.Summa(a, b));
            Console.WriteLine("Erotus: " + Laskin.Erotus(a, b));
            Console.WriteLine("Kertolasku: " + Laskin.Kertolasku(a, b));
            Console.WriteLine("Jakolasku: " + Laskin.Jakolasku(a, b));
        }
    }
}
