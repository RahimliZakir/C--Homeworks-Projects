using LibraryConsoleApp.Main_Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.OutputEncoding = Encoding.UTF8;
            List<AboutBook> library = new List<AboutBook>();

            var object1 = new AboutBook();
            object1.Name = "Qərb Bürküsü";
            object1.AuthorName = "Çingiz Abdullayev";
            object1.PublishDate = 2013;
            object1.PageCount = 300;
            library.Add(object1);

            var object2 = new AboutBook("Ürəkdə bəslənən sevdaya şükür", "Nəsir Dalğın", 2008, 176);
            library.Add(object2);

            var object3 = new AboutBook
            {
                Name = "Səs və ya qırmızı",
                AuthorName = "Şamxal Həsənov",
                PublishDate = 2020,
                PageCount = 200
            };
            library.Add(object3);

            
            
            int i = 1;
            string DinamikSay = null;




            foreach (var book in library)
            { switch (i % 10)
            {
                case 1:
                case 2:
                case 5:
                case 7:
                case 8:
                        DinamikSay = $"{i}-ci";
                    break;

                case 3:
                case 4:
                        DinamikSay = $"{i}-cü";
                    break;

                case 6:
                        DinamikSay = $"{i}-cı";
                    break;

                case 9:
                        DinamikSay = $"{i}-cu";
                    break;
                default:
                    break;}
                i++;
                //Console.WriteLine(book);
                Console.WriteLine($"{DinamikSay} kitabın adı: {book.Name}");
                Console.WriteLine($"{DinamikSay} kitabın müəllifi: {book.AuthorName}");
                Console.WriteLine($"{DinamikSay} kitabın çap tarixi: {book.PublishDate}");
                Console.WriteLine($"{DinamikSay} kitabın səhifələrinin sayı: {book.PageCount}");
            }

            Console.ReadKey();
        }
    }
}
