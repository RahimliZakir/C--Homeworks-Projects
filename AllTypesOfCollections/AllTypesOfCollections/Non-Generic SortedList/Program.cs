using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SortedList sortedList = new SortedList() { {2, "Nurlan"} };

            sortedList.Add(3, "Orxan");
            sortedList.Add(1, "İbrahim");

            Console.WriteLine($"Key vasitəsilə elementin tapılması: {sortedList[2]}");
            sortedList.TrimToSize(); 
            Console.WriteLine($"SortedList'in ala biləcəyi yaddaş: {sortedList.Capacity}");

            if(sortedList.Contains(3) == false)
            {
                Console.WriteLine("Tapılmadı...");
            }
            else
            {
                Console.WriteLine("Tapıldı...");
            }

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
