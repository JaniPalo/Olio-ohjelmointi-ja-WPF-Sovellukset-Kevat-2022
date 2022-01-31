using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace tehtävä_12
{
    public static class Program
    {

        static void Main(string[] args)
        {
            pakka pakka2 = new pakka();
            pakka2.Tulosta();
            pakka pakka1 = new pakka();
            pakka1.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0,19}", pakka1.Tulosta());
                
                


                
            }
          
        }

       
     }
}
    
