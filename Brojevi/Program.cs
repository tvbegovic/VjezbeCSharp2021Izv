using System;

namespace Brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Broj elemenata: ");
                var unos = Console.ReadLine();
                if(string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = int.TryParse(unos, out int brojElemenata);
                    if(!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    int[] brojevi = new int[brojElemenata];
                    var i = 0;
                    while(i < brojElemenata)
                    {
                        Console.Write("Element {0}: ", i + 1);
                        unos = Console.ReadLine();
                        ok = int.TryParse(unos, out brojevi[i]);
                        if(!ok)
                        {
                            Console.WriteLine("Pogrešan format");
                            continue;
                        }
                        i++;
                    }
                    var suma = 0;
                    var najmanji = int.MaxValue;    //drugo rješenje: brojevi[0]
                    var najveci = int.MinValue;
                    foreach (var broj in brojevi)
                    {
                        suma += broj;
                        if (broj < najmanji)
                            najmanji = broj;
                        if (broj > najveci)
                            najveci = broj;
                    }
                    var prosjek = suma * 1.0 / brojElemenata;
                    Console.WriteLine("Suma brojeva je {0}", suma);
                    Console.WriteLine("Prosjek je {0:N2}", prosjek);
                    Console.WriteLine("Najveći element je {0}", najveci);
                    Console.WriteLine("Najmanji element je {0}", najmanji);
                }
            } while (nastavi);
        }
    }
}
