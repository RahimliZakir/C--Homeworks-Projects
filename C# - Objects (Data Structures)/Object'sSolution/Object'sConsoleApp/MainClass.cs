using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_sConsoleApp
{
    class MainClass
    {
        static void Main(string[] args)
        {   List<OtherHiredOne> bilgiler = new List<OtherHiredOne>();

            var ilkShexsiyyet = new OtherHiredOne("Ilkin", "Agazade", "Evli");
            bilgiler.Add(ilkShexsiyyet);

            var ikinciShexsiyyet = new OtherHiredOne {
            ad = "Dadash",
                soyad = "Nebizade",
                AileVeziyyeti = "Evli"
            };
            bilgiler.Add(ikinciShexsiyyet);

            OtherHiredOne uchuncuShexsiyyet = new OtherHiredOne();
            uchuncuShexsiyyet.ad = "Zakir";
            uchuncuShexsiyyet.soyad = "Rahimli";
            uchuncuShexsiyyet.AileVeziyyeti = "Ayriliq";
            bilgiler.Add(uchuncuShexsiyyet);

            foreach (var bilgi in bilgiler)
            {
                Console.WriteLine($"{bilgi.ad}, {bilgi.soyad}, {bilgi.AileVeziyyeti}");
            }

            Console.ReadKey();
        }
    }
}
