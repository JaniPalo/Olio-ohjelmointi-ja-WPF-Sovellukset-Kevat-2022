using System;

namespace HarjoitusAjoneuvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo Auto1 = new Ajoneuvo();
            Auto1.Nimi = "Opel";
            Auto1.Renkaat = 4;
            Auto1.Nopeus = 120;

            Auto1.DataTulostus();

            Ajoneuvo Mopo = new Ajoneuvo();
            Mopo.Nimi = "Yamaha";
            Mopo.Renkaat = 2;
            Mopo.Nopeus = 70;

            Mopo.DataTulostus();


        }
    }
}
