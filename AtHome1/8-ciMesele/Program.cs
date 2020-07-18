using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            decimal decA = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            decimal decB = Convert.ToDecimal(Console.ReadLine());

            decimal DordFaiz = (decA * 4) / 100;
            Console.WriteLine($"1-ci ededin 4 faizi: {DordFaiz}");

            decimal DoqquzFaiz = (decB * 4) / 100;
            Console.WriteLine($"2-ci ededin 9 faizi: {DoqquzFaiz}");

            decimal CeminOnFaizi = ((DoqquzFaiz + DordFaiz) * 10) / 100;
            Console.WriteLine($"Son cavabin 10 faizi: {CeminOnFaizi}");

            Console.ReadKey();
        }
    }
}
