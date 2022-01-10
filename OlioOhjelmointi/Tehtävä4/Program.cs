using System;

namespace Tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.Lisääkappale(new Kappale("Song1", "4,30"));
            albumi.Lisääkappale(new Kappale("Song2", "2,10"));
            albumi.Lisääkappale(new Kappale("Song3", "6,30"));
            albumi.Lisääkappale(new Kappale("Song4", "5,05"));

            albumi.TulostaKappaleet();
        }
    }
}
