using System;

namespace IzracunKamata
{
    class Program
    {
        //Definiraj funkciju izracunkamata

        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Glavnica: ");
                var unos = Console.ReadLine();
                if (string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = decimal.TryParse(unos, out decimal glavnica);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    Console.Write("Stopa (0-20%): ");
                    unos = Console.ReadLine();
                    ok = decimal.TryParse(unos, out decimal stopa);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    if(stopa < 0 || stopa > 20)
                    {
                        Console.WriteLine("Stopa je izvan raspona");
                        continue;
                    }
                    //pozovi funkciju i ispiši rezultat                    

                }
            } while (nastavi);
        }
    }
}
