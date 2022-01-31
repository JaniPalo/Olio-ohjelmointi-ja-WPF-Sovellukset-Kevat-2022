using System;
using System.Collections.Generic;
using System.Text;

namespace tehtävä_12
{
    public class pakka
    {
        private Kortti[] Pakka;
        private int nykyinenKortti;
        // asetetaan pakan määräksi 52
        private const int korttienMäärä = 52;
        private Random rnd;

        public pakka()
        {
            //tehdään arrayt numeroille ja arvoille
            string[] Numerot = { "Ässä ", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen", "Jack", "kuningatar", "kuningas" };
            string[] Arvot = { "sydän", "pata", "timantti", "ruutu" };

            Pakka = new Kortti[korttienMäärä];
            nykyinenKortti = 0;
            rnd = new Random();

            for (int count = 0; count < Pakka.Length; count++)
            {
                Pakka[count] = new Kortti(Numerot[count % 11], Arvot[count / 13]);
            }
            
        }
        public void Shuffle()
        {
            nykyinenKortti = 0;
            for (int i = 0; i < Pakka.Length; i++)
            {
                int j = rnd.Next(korttienMäärä);
                Kortti temp = Pakka[i];
                Pakka[i] = Pakka[j];
                Pakka[j] = temp;
            }

        }
        public Kortti Tulosta()
        {
            if (nykyinenKortti < Pakka.Length)
            {
                return Pakka[nykyinenKortti++];
            }
            else
            {
                return null;
            }
        }
    }
}
