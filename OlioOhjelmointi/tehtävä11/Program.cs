using System;
using System.Collections.Generic;

namespace tehtävä11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine(" ");
                Console.WriteLine("1. Lisää: lisää listaan ");
                Console.WriteLine("2. Poista: poista listasta ");
                Console.WriteLine("3. tulosta: tulosta listaan ");
                Console.WriteLine("4. Poistu:  poistu listasta ");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "lisää":
                        lisääOpiskelija(opiskelijat);
                        break;
                    case "poista":
                        poistaOpiskelija(opiskelijat);
                        break;
                    case "tulosta":
                        TulostaOpiskelijat(opiskelijat);
                        break;
                    case "poistu":
                        return;
                    default:

                        break;
                }
            }
        }

        static void lisääOpiskelija(Dictionary<int,Opiskelija> opiskelijat)
        {          
            Opiskelija newOpiskelija = new Opiskelija();

            while (true)
            {
                Console.WriteLine("Anna uuden opiskelijan tiedot: ");
                Console.WriteLine("Etunimi: ");
                Console.WriteLine("Etunimi: ");
                newOpiskelija.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                newOpiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine("Ryhmätunnus: ");
                newOpiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine("OpiskelijaID");
                newOpiskelija.OpiskelijaNumero = Convert.ToInt32(Console.ReadLine());

                if (opiskelijat.ContainsKey(newOpiskelija.OpiskelijaNumero))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    continue;
                }
                else
                {
                    opiskelijat.Add(newOpiskelija.OpiskelijaNumero, newOpiskelija);
                    break;
                }
            }
        }
        static void poistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan opiskelijaID jonka haluat poistaa: ");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelija" + opiskelijat[syöte].Etunimi + " poistettu ");
            }
            else
            {
                Console.WriteLine("Opiskelija ID:llä " + syöte + " ei löydetty listasta ");
            }
            opiskelijat.Remove(syöte);
        }

        static void TulostaOpiskelijat(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach  (Opiskelija item in opiskelijat.Values)
            {
                item.TulostaData();
            }

        }
    }
}
