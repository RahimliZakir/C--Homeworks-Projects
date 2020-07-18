using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_cuMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            decimal decA = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            decimal decB = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Uchuncu ededi daxil edin: ");
            decimal decC = Convert.ToDecimal(Console.ReadLine());

            decimal OnFaizlerininCemi = ((decA * 10) / 100) + ((decB * 10) / 100) + ((decC * 10) / 100);
            Console.WriteLine($"Ededlerin 10 faizinin cemi: {OnFaizlerininCemi}");

            decimal CeminOnFaizi = (OnFaizlerininCemi * 10) / 100;
            Console.WriteLine($"Cemin 10 faizi: {CeminOnFaizi}");

            Console.ReadKey();
        }
    }
}
