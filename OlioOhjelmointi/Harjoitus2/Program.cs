using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Pekka", " 1929" ,0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintoPisteitä(15);
            opiskelija1.MuokkaaOpintoPisteitä(20);
            opiskelija1.TulostaData();

        }
    }
}
