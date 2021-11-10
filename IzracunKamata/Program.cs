using System;

namespace IzracunKamata
{
    class Program
    {
        //Definiraj funkciju izracunkamata
        static decimal IzracunKamata(decimal glavnica, decimal stopa)
        {
            if(stopa < 0 || stopa > 20)
            {
                throw new ArgumentOutOfRangeException("Stopa je izvan raspona");
            }
            var rezultat = glavnica * stopa / 100;
            return rezultat;
        }

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
                    //Izbacujemo jer je provjera u funkciji
                    /*if(stopa < 0 || stopa > 20)
                    {
                        Console.WriteLine("Stopa je izvan raspona");
                        continue;
                    }*/
                    try
                    {
                        var kamata = IzracunKamata(glavnica, stopa);
                        Console.WriteLine("Za unesenu glavnicu {0:N2} i kamatnu stopu {1}% iznos kamata je {2:N2}",
                            glavnica, stopa, kamata);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
                    }

                }
            } while (nastavi);
        }
    }
}
