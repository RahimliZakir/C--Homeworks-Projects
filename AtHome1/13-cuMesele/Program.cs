using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_cuMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Ikinci ededi daxil edin: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Uchuncu ededi daxil edin: ");
            decimal c = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Dorduncu ededi daxil edin: ");
            decimal d = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Beshinci ededi daxil edin: ");
            decimal e = Convert.ToDecimal(Console.ReadLine());


            decimal a1 = (a * 5) / 100;
            decimal b1 = (b * 5) / 100;
            decimal c1 = (c * 5) / 100;
            decimal hasil = (a1 * b1 * c1);
            decimal d1 = (d * 3) / 100;
            decimal e1 = (e * 3) / 100;
            decimal cem = (d1 + e1);
            decimal faiz = (hasil * 10) / 100;
            decimal faiz1 = (cem * 10) / 100;
            decimal cavab = (faiz + faiz1);
            Console.WriteLine($"Yekun cavab: {cavab}");

            Console.ReadKey();
        }
    }
}
