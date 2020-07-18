using ConsoleApp.AboutGoods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           

            AboutGoodsClass goods1 = new AboutGoodsClass();

            Console.Write("Əmtəənin adını daxil edin: ");
            string emteeAdi = Console.ReadLine();

            Console.Write("Əmtəənin qiymətini daxil edin: ");
            string emteeQiymetistr = Console.ReadLine();
            double emteeQiymeti = Convert.ToDouble(emteeQiymetistr);

            Console.Write("Əmtəənin çəkisini daxil edin: ");
            string emteeChekisistr = Console.ReadLine();
            double emteeChekisi = Convert.ToDouble(emteeChekisistr);

            goods1 = new AboutGoodsClass(emteeAdi, DateTime.Now, emteeQiymeti, emteeChekisi);

            goods1.ElaveOlundu();

            KeypressGoods KeyPress = new KeypressGoods();
            KeyPress.Keypress();

            string Keystr = Console.ReadLine();
            int Key = Convert.ToInt32(Keystr);

            

            if (Key == 1)
            {
                goods1.ChekideDeyishiklik();

            }
            else if(Key == 2)
            {
                goods1.Satmaq();
            }

            else if(Key == 3)
            {
                return;
            }
            
            else
            {
                Console.WriteLine("Zəhmət olmasa yalnız göstərilən rəqəmlərə click edin.");
            }


            Console.ReadKey();
        }
    }
}
