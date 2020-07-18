using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_cuMesele
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

            decimal BirinciEdedinBirFaizi = (decA * 1) / 100;
            Console.WriteLine($"Birinci ededin 1 faizi: {BirinciEdedinBirFaizi}");
            decimal IkinciEdedinIkiFaizi = (decB * 2) / 100;
            Console.WriteLine($"Ikinci ededin 2 faizi: {IkinciEdedinIkiFaizi}");
            decimal UchuncuEdedinUchFaizi = (decC * 3) / 100;
            Console.WriteLine($"Uchuncu ededin 3 faizi: {UchuncuEdedinUchFaizi}");

            decimal ferq = BirinciEdedinBirFaizi - IkinciEdedinIkiFaizi - UchuncuEdedinUchFaizi;
            Console.WriteLine($"Ededlerin son halinin bir-birinden ferqi: {ferq}");

            decimal UchuncuEdedinYeddiFaizi = (decC * 7) / 100;
Console.WriteLine($"Alinan cavabin ustune uchuncu ededin 7 faizi elave edilmish hali: {ferq + UchuncuEdedinYeddiFaizi}");

            Console.ReadKey();
        }
    }
}
