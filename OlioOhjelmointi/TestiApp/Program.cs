using System;

namespace TestiApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Koira koira1 = new Koira();
            koira1.nimi = "Rekku";
            koira1.ikä = 4;
            koira1.rotu = " Saksanpaimenkoira";

            koira1.TulostaData();
            koira1.Hauku();

            Koira koira2 = new Koira();
            koira2.nimi = "Pertti";
            koira2.ikä = 2;
            koira2.rotu = " Mopsi";

            koira2.TulostaData();
            
        }
    }
}
