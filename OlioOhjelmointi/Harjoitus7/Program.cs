using System;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);
            string syöte;

            while (true)
            {
                Console.WriteLine("Olet kerroksessa: " + hissi.NykyinenKerros1);
                Console.WriteLine("Mihin kerrokseen haluat? ");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine(" Poistuit hissistä ");
                    break;
                }
                else
                {
                    hissi.NykyinenKerros1 = int.Parse(syöte); 
                }
            }
        }
    }
}
