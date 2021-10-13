using System;

namespace Inicijali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ime: ");
            var ime = Console.ReadLine();
            Console.Write("Prezime: ");
            var prezime = Console.ReadLine();
            if(string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
            {
                Console.WriteLine("Niste upisali ime ili prezime");
                return;
            }
            Console.WriteLine("Vaši inicijali su: {0}.{1}.", ime[0], prezime.Substring(0, 1));
        }
    }
}
