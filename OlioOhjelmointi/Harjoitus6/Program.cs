using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
           Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            Koira koira1 = new Koira("Terrieri",2);
            Koira koira2 = new Koira("Saksanpaimenkoira", 5);

            Kissa kissa1 = new Kissa("Valkoinen", 2);
            Kissa kissa2 = new Kissa("Musta", 4);

            kissa1.Ääntele();
            kissa2.Ääntele();
            koira1.Ääntele();
            koira2.Ääntele();

            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();
            Eläin.KuinkaMonta();


        }
    }
}
