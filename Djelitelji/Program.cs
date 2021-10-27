using System;

namespace Djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj (1-100.000): ");
            var unos = Console.ReadLine();
            var ok = int.TryParse(unos, out int broj);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(broj < 1 || broj > 100000)
            {
                Console.WriteLine("Broj je izvan raspona");
                return;
            }
            long suma = 0;
            for (int i = 1; i <= broj ; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;  //kraće za suma = suma + i
                }
            }
            Console.WriteLine("Suma brojeva djeljivih s 3 ili 5 od 1 do {0} je {1:N0}",
                broj, suma);
        }
    }
}
