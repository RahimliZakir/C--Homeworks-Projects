using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_cuMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil et: ");
            decimal decA = Convert.ToDecimal(Console.ReadLine() + 7);
            Console.WriteLine($"Ededin sonuna 7 yazilmish hali: {decA}");

            decimal YeddiFaiz = (decA * 7) / 100;

            Console.WriteLine($"Ededin son halinin 7 faizi: {YeddiFaiz}");
            Console.ReadKey();
        }
    }
}
