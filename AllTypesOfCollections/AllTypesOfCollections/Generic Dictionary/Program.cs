using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<int, string> dictionary = new Dictionary<int, string>() { {1, "Bir"} };

            dictionary.Add(2, "İki");
            dictionary.Add(3, "Üç");

            Console.WriteLine($"Dictionary'nin uzunluğu: {dictionary.Count}");

            Console.WriteLine("-----------------------------------------------------------------------------");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"Dictionary'nin key'ləri və value'ları:  {item.Key}, {item.Value}.");
            }

            dictionary.Remove(2);

            Console.WriteLine("-----------------------------------------------------------------------------");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"Dictionary'nin key'ləri və value'ları:  {item.Key}, {item.Value}.");
            }


            Console.WriteLine("-----------------------Contains or ContainsKey-------------------------------");

            if(dictionary.ContainsKey(3) == false)
            {
                Console.WriteLine("Tapılmadı...");
            }
            else
            {
                Console.WriteLine("Tapıldı...");
            }
            

            Console.ReadKey();
        }
    }
}
