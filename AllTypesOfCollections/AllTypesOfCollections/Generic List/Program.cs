using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> list = new List<int>() {1, 2, 3};

            list.Add(4);
            //list.AddRange(new List<int> { 5, 6});
            list.Insert(4, 7); //Sechilmish indexe sechdiyimiz int tipli deyishen elave etmek.

            list.TrimExcess();
            Console.WriteLine($"List'in uzunluğu: {list.Count}");
            Console.WriteLine($"List'in tutum qabiliyyəti: {list.Capacity}");

            list.Remove(2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(0); //Indexle silir.

            Console.WriteLine("------------------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Clear(); //Butun elementleri silir.

            Console.WriteLine("------------------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
