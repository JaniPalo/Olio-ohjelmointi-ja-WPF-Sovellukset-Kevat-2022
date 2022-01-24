using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas( "Kiuas", 30, 20);
            kiuas1.NäytäTiedot();
            kiuas1.Tila = true;
            kiuas1.NäytäTiedot();
            
        }
    }
}
