using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_cuMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil et: ");
            decimal decA = Convert.ToDecimal(Console.ReadLine());
            decimal OnSekkizFaiz = (decA * 18) / 100;
            decimal UchFaiz = (decA * 3) / 100;

            Console.WriteLine($"Ededin 18 faizi: {OnSekkizFaiz}");
            Console.WriteLine($"Ededin 3 faizi: {UchFaiz}");
            Console.ReadKey();
        }
    }
}
