﻿using System;

namespace Abstraktisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Nimi = "Matti";
            opiskelija.Puhu();


            Henkilö.KuinkaMonta();
        }
    }
}
