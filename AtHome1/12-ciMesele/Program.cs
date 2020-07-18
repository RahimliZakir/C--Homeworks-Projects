using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());


            Console.Write("ikinci ededi daxil edin: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Uchuncu ededi daxil edin: ");
            decimal c = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Dorduncu ededi daxil edin: ");
            decimal d = Convert.ToDecimal(Console.ReadLine());


            decimal a1 = (a * 10) / 100;
            decimal b1 = (b * 10) / 100;
            decimal c1 = (c * 10) / 100;
            decimal d1 = (d * 10) / 100;
            decimal cem = (a1 + b1 + c1 + d1);
            decimal a11 = (a * 15) / 100;
            decimal b11 = (b * 15) / 100;
            decimal c11 = (c * 15) / 100;
            decimal d11 = (d * 15) / 100;
            decimal cem1 = (a11 + b11 + c11 + d11);
            decimal hasil = (cem * cem1);
            decimal cavab = (hasil * 10) / 100;
            decimal YekunCavab = (cavab * 11) / 100;
            Console.WriteLine($"Yekun cavab: {YekunCavab}");

            Console.ReadKey();
        }
    }
}
