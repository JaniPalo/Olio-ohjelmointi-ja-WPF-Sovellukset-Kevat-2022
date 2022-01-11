using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Henkilö henkilö = new Henkilö("Matti", 20, 1042104); 
            Opiskelija opiskelija = new Opiskelija("Jorma", 18, 2155821, 12345, "Careeria"); 

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();

            Henkilö.KuinkaMontaHenkilöä();
            Opiskelija.KuinkaMontaOpiskelijaa();
          
           
        }
    }
}