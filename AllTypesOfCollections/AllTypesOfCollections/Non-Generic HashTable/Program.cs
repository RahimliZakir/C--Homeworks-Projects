using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Hashtable hashTable = new Hashtable() { {"qerdesh1", "Əliyar"} };

            hashTable.Add("qerdesh2", "Orxan");
            hashTable.Add("qerdesh3", "İbrahim");
            hashTable.Add("qerdesh4", "Nurlan");

            Console.WriteLine($"HahsTable'ın uzunluğu: {hashTable.Count}");
            Console.WriteLine($"HahsTable'ın elementlərinin key ilə tapılması: {hashTable["qerdesh1"]}, " +
                $"{hashTable["qerdesh2"]}, {hashTable["qerdesh3"]}.");

            hashTable.Remove("qerdesh2"); //Keyi "qerdesh2" olan value ilə keyi sildi.

            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine($"HashTabe'ın key'lərini və value'larının tapılması: {item.Key}, {item.Value}");
            }

            if(hashTable.ContainsKey("qerdesh1") == true)
            {
                Console.WriteLine("Düzdür, belə bir key'li element var.");
            }
            else
            {
                Console.WriteLine("Səhvdir, belə bir key'li element yoxdur.");
            }

            Console.ReadKey();
        }
    }
}
