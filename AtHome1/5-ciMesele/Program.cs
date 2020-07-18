using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            decimal decA = decimal.Parse(4 + Console.ReadLine() + 44);
            Console.WriteLine($"Evveline 4, sonuna ise 44 elave olunmus hali: {decA}");


            decimal QirxDordFaiz = (decA * 44) / 100;
            Console.WriteLine($"Ededin son halinin 44 faizi: {QirxDordFaiz}");
            Console.ReadKey();
        }
    }
}
