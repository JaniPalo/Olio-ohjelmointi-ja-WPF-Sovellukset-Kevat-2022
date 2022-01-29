using System;

namespace Tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            
            albumi.Lisääkappale(new Kappale("- " + "Nimi: " + "Dreams", "4,17"));
            albumi.Lisääkappale(new Kappale("- " + "Nimi: " + "Chain", "2,10"));
            albumi.Lisääkappale(new Kappale("- " + "Nimi: " + "I dont want to know", "6,30"));
            albumi.Lisääkappale(new Kappale("- " + "Nimi: " + "Never going back again", "2,02"));
            albumi.Lisääkappale(new Kappale("- "+ "Nimi: " + " Dont stop", "2,20"));

            Console.WriteLine("ALBUMI");
            albumi.TulostaAlbumi();
            Console.WriteLine("KAPPALEET");
            albumi.TulostaKappaleet();
            
        }
    }
}
