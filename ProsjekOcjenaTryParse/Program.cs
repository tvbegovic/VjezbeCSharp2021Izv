using System;

namespace ProsjekOcjenaTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ocjena C: ");
            var unos = Console.ReadLine();
            var ok = int.TryParse(unos, out int ocjenaC);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(ocjenaC > 5 || ocjenaC < 1)
            // if (!(ocjenaC >= 1 && ocjenaC <=5))  //Alternativni uvjet
                {
                Console.WriteLine("Ocjena nije u rasponu 1-5");
                return;
            }
            Console.Write("Ocjena C++: ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out int ocjenaCPlus);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            Console.Write("Ocjena C#: ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out int ocjenaCSharp);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
            Console.WriteLine("Prosjek ocjena je {0:N2}", prosjek);

        }
    }
}
