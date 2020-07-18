using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ciMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uchuncu ededi daxil edin: ");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dorduncu ededi daxil edin: ");
            int D = Convert.ToInt32(Console.ReadLine());

            int BirinciUchuncuEdedinCemi = A + C;
            Console.WriteLine($"1-ci ve 3-cu ededlerin cemi: {BirinciUchuncuEdedinCemi}");
            int IkinciDorduncuEdedinCemi = B + D;
            Console.WriteLine($"2-ci ve 4-cu ededlerin cemi: {IkinciDorduncuEdedinCemi}");

            int CavablarinHasili = BirinciUchuncuEdedinCemi * IkinciDorduncuEdedinCemi;
            Console.WriteLine($"Cavablarin hasili: {CavablarinHasili}");

            decimal UchuncuEdedinDecimali= Convert.ToDecimal(C);
            decimal UchuncuEdedinUchFaizi = (UchuncuEdedinDecimali * 3) / 100;
            Console.WriteLine($"3-cu ededin 3 faizi: {UchuncuEdedinUchFaizi}");
            Console.WriteLine($"Cavablarin hasilinden 3-cu ededin 3 faizinin cixilmasi: {CavablarinHasili - UchuncuEdedinUchFaizi}");

            Console.ReadKey();
        }
    }
}
