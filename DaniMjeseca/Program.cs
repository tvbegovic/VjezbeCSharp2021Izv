﻿using System;

namespace DaniMjeseca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite redni broj mjeseca (1-12): ");
            var unos = Console.ReadLine();
            var ok = int.TryParse(unos, out int redniBroj);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(redniBroj < 1 || redniBroj > 12)
            {
                Console.WriteLine("Broj nije u rasponu 1-12");
                return;
            }
            int brojDana;
            var sufix = "a";
            switch(redniBroj)
            {
                case 2:
                    if(DateTime.IsLeapYear(DateTime.Now.Year))
                    {
                        brojDana = 29;
                    }
                    else
                    {
                        brojDana = 28;
                    }             
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    brojDana = 30;
                    break;
                default:
                    brojDana = 31;
                    sufix = string.Empty;
                    break;
            }
            Console.WriteLine("{0}. mjesec ima {1} dan{2}", redniBroj, brojDana, sufix);
        }
    }
}
