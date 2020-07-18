using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AboutGoods
{
    class AboutGoodsClass
    {
        public AboutGoodsClass()
        {

        }

        public AboutGoodsClass(string name, DateTime arrive, double price, double weight)
        {
            this.Name = name;
            this.ArriveTime = arrive;
            this.Price = price;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public DateTime ArriveTime { get; set; }

        public double Price { get; set; }

        public double Weight { get; set; }

        public void Satmaq()
        {
            Console.Write("Satılacaq olan malın çəkisini daxil edin: ");
            string satilacaqMalstr =  Console.ReadLine();
            double satilacaqMal = Convert.ToDouble(satilacaqMalstr);

            if(satilacaqMal > Weight)
            {
                Console.WriteLine("Bazada yetərli çəkidə əmtəə yoxdur!");
            }
            else if(satilacaqMal == Weight || satilacaqMal < Weight)
            {
                Console.WriteLine($"Əmtəə satıldı, anbarda qalan əmtəənin miqdarı {Weight - satilacaqMal} kg");
            }
        }


        public void ChekideDeyishiklik()
        {
            Console.Write("Satılacaq olan malın çəkisini əlavə edin: ");
            string chekideDeyishiklikstr = Console.ReadLine();
            int chekideDeyishiklik = Convert.ToInt32(chekideDeyishiklikstr);

            Console.WriteLine($"Əmtəə yeniləndi, əmtəə haqqında: {Name}, {ArriveTime}, {Price} ₼, {Weight + chekideDeyishiklik} kg");
        }

        public void ElaveOlundu()
        {
            Console.WriteLine($"Əmtəə əlavə olundu, əmtəə haqqında: {Name}, {ArriveTime}, {Price} ₼, {Weight} kg");
        }
    }
}
