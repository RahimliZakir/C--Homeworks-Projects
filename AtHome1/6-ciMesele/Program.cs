using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            decimal decA = decimal.Parse(Console.ReadLine());

            decimal IyirmiFaiz = (decA * 20) / 100;
            Console.WriteLine($"Alinmish cavabin 20 faizi: {IyirmiFaiz}");
            decimal IyirmiFaizinOnFaizi = (IyirmiFaiz * 10) / 100;
            Console.WriteLine($"Alinmish cavabin 20 faizinin 10 faizi: {IyirmiFaizinOnFaizi}");

            Console.WriteLine($"Alinmish son cavabin kvadrati {IyirmiFaizinOnFaizi * IyirmiFaizinOnFaizi}");
            Console.ReadKey();
        }
    }
}
