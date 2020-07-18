using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_cuMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Ikinci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Uchuncu ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Dorduncu ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Beshinci ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altinci ededi daxil edin: ");
            int g = Convert.ToInt32(Console.ReadLine());


            int cem = a + b + c + d + e + g;
            string a1 = a.ToString();
            string c1 = c.ToString();
            string a4 = ($"{a1}{c1}");
            long a5 = Convert.ToInt64(a4);
            long cixma = a5 - cem;
            double tap = (double)(cixma * 10) / 100;
            double umumi = (double)(tap + e + g);
            double cavab = (double)(umumi * 11) / 100;
            Console.WriteLine($"Yekun cavab: {cavab}");

            Console.ReadKey();
        }
    }
}
