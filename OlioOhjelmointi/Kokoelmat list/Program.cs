using System;
using System.Collections.Generic;

namespace Kokoelmat_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LISTA");
            Console.WriteLine("");
            List <string> lista = new List<string>();
            lista.Add("Pekka");
            lista.Add("Niilo");
            lista.Add("Beni");

            lista.Remove("Pekka");

            foreach  (string item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("PINO");
            Console.WriteLine("");
            Stack<string> pino = new Stack<string>();

            pino.Push("kortti 1");
            pino.Push("kortti 2");
            pino.Push("kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia ");
            Console.WriteLine(pino.Peek());

            pino.Pop();
            Console.WriteLine("Pinossa on " + pino.Count + " objektia ");
            Console.WriteLine(pino.Peek());

            Console.WriteLine("");
            Console.WriteLine("JONO");
            Console.WriteLine("");

            Queue<string> Jono = new Queue<string>();
            Jono.Enqueue("Pekka");
            Jono.Enqueue("Jussi");
            Jono.Enqueue("Niilo");

            Console.WriteLine("Jonossa on " + Jono.Count + " henkilöä ");
            Console.WriteLine(Jono.Peek() + " on ensimmäinen jonossa ");

            Jono.Dequeue();
            Console.WriteLine("Jonossa on " + Jono.Count + " henkilöä ");
            Console.WriteLine(Jono.Peek() + " on ensimmäinen jonossa ");

            Console.WriteLine("");
            Console.WriteLine("SANAKIRJA");
            Console.WriteLine("");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("233222-1232", "Pekka");
            sanakirja.Add("020312-2344", "Jussi");


            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + " henkilöä ");
            Console.WriteLine("Etsitään sanakirjasta avaimella [233222-1232], Henkilö on " + sanakirja[ "233222-1232" ]);

            foreach (string avain in sanakirja.Keys)
            {
                Console.WriteLine("Sanakirjasta haettu avaimella. " + avain + " " + "Value: " + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine("Sanakirjasta haettu valuella. " + henkilö + "" + " Henkilön avain: " );
            }
            //Console.WriteLine("Etsitään sanakirjasta avaimella [233222-3243], Henkilö on " + sanakirja["233222-3243"]);
             //sanakirja.Add("233222-1232", "Toni");
        }
    }
}
