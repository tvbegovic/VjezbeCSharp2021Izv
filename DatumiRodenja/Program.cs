﻿using System;

namespace DatumiRodenja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Datum 1: ");
            var unos = Console.ReadLine();
            var ok = DateTime.TryParse(unos, out DateTime datum1);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            Console.Write("Datum 2: ");
            unos = Console.ReadLine();
            ok = DateTime.TryParse(unos, out DateTime datum2);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(datum1 < datum2)
            {
                Console.WriteLine("Osoba 1 je starija od osobe 2 za {0} dana",
                    (datum2 - datum1).Days);
            }
            else if(datum2 < datum1)
            {
                Console.WriteLine("Osoba 2 je starija od osobe 1 za {0} dana",
                    (datum1 - datum2).Days);
            }
            else
            {
                Console.WriteLine("Obje osobe su rođene istog datuma");
            }

            if(datum1.DayOfYear < datum2.DayOfYear)
            {
                Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
            }
            else if(datum2.DayOfYear < datum1.DayOfYear)
            {
                Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
            }
            else
            {
                Console.WriteLine("Osobe slave rođendan na isti dan");
            }
        }
    }
}
