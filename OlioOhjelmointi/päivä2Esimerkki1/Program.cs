using System;

namespace päivä2Esimerkki1
{
    class Program
    {
        static void Main(string[] args)
        {
            float km = 50f;
            float maili = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + " kilometriä on yhtä kuin " + maili + " mailia ");
        }
    }
}
