using System;

namespace KT8
{
     class Program
    {
        static void Main(string[] args)
        {
            Henkilö työntekijäHenkilö = new Työntekijä("Jussi", 1500, "Careeria");
            työntekijäHenkilö.henkilöTiedot();

            Henkilö työntekijä = new Työntekijä(43);
            
            työntekijä.asiat();
            Henkilö työntekijäHenkilö2 = new Työntekijä("Pekka", 1200, "Traficom");
            työntekijäHenkilö2.henkilöTiedot();
            Henkilö työntekijä2 = new Työntekijä(32);
            työntekijä2.asiat();

            Henkilö pomoHenkilö = new Pomo("Simo", 2000, "Jokelan vankila");
            pomoHenkilö.henkilöTiedot();

            Henkilö pomo = new Pomo("Opel", 10);
            pomo.asiat();
           
            
            

            
            


        }
    }
}