﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    class Hissi
    {
        private int MinKerros;
        private int MaxKerros;

        private int NykyinenKerros;

        public Hissi(int minKerros, int maxKerros)
        {
            MinKerros = minKerros;
            MaxKerros = maxKerros;
            NykyinenKerros = minKerros;
        }

        public int NykyinenKerros1
        {
            get => NykyinenKerros;          
            set 
        {  
               if (value > MaxKerros || value < MinKerros)
             {
                    Console.WriteLine("Virheellinen Kerros!!!");
             }    
               else
             {
                    NykyinenKerros = value;
             }

        }
      }
   }
}