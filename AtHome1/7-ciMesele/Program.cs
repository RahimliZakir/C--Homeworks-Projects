using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            decimal decA = decimal.Parse(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            decimal decB = decimal.Parse(Console.ReadLine());

            decimal decCem = decA + decB;
            Console.WriteLine($"Ededlerin cemi: {decCem}");

            string strBeshCemBesh = 5 + decCem.ToString() + 5;
            Console.WriteLine($"Ededlerin ceminin onune ve axirina 5 elave olunmush hali: {strBeshCemBesh}");

            decimal decstrBeshCemBesh = decimal.Parse(strBeshCemBesh);
            decimal BeshFaiz = (decstrBeshCemBesh * 5) / 100;
            Console.WriteLine($"Son cavabin 5 faizi: {BeshFaiz}");
            Console.ReadKey();
        }
    }
}
