using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ciMesele
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
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yeddinci ededi daxil edin: ");
            int g = Convert.ToInt32(Console.ReadLine());

            long c3 = a + b;
            long c4 = c + d;
            long hasil = c * d;
            long cem = c3 + hasil;
            long c5 = e + f;
            string cem1 = cem.ToString();
            string cem2 = $"{cem1}7";
            long cev = Int64.Parse(cem2);
            long cem3 = cev + c5;
            long h3 = a * b;
            string h1 = h3.ToString();
            string h2 = $"{h1}1";
            long h4 = Int64.Parse(h2);
            long cixma = cem - h4;
            long rq = cixma + g;
            long cixma2 = rq - (c3 + c4);
            double faiz = (double)(((((cixma2 * 18) / 100) * 3) / 100) * 1) / 100;
            double cavab = (double)(faiz + c5);
            Console.WriteLine($"Yekun netice: {c5}");

            Console.ReadKey();
        }
    }
}
