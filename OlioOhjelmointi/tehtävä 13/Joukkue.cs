using System;
using System.Collections.Generic;
using System.Text;

namespace tehtävä_13
{
    class Joukkue 
    {
        public string Nimi;
        public string Kotikaupunki;

        private Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();
       

        public void lisääPelaaja(Dictionary<int,Pelaaja> pelaajat)
        {
            Pelaaja newPelaaja = new Pelaaja();

            while (true)
            {
               
                Console.WriteLine("Etunimi: ");
                newPelaaja.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                newPelaaja.Sukunimi = Console.ReadLine();
                Console.WriteLine("PelaajaNumero: ");
                newPelaaja.pelaajaNumero = Convert.ToInt32(Console.ReadLine());
                

               
               
                
            }
            static void poistaPelaajat(Dictionary<int, Pelaaja> pelaajat)
            {
                Console.WriteLine("Anna pelaaja jonka haluat poistaa: ");
                int syöte = Convert.ToInt32(Console.ReadLine());

                if (pelaajat.ContainsKey(syöte))
                {
                    Console.WriteLine("pelaaja" + pelaajat[syöte].Etunimi + " poistettu ");
                }
                else
                {
                    Console.WriteLine("Pelaaja " + syöte + " ei löydetty listasta ");
                }
                pelaajat.Remove(syöte);
            }
        }
    }
    
 }
