using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ArrayList arrayList = new ArrayList() {"Hi", DateTime.Now};

            arrayList.Add("Salam");
            arrayList.Add(5.5);
            arrayList.Add(true);
            arrayList.AddRange(new List<int> { 1, 2, 5, 7});

            Console.WriteLine($"Listin elementlərinin sayı,uzunluğu: {arrayList.Count}");
            arrayList.TrimToSize(); //Istifade olunmayan artiq saheni silir.
            Console.WriteLine($"Listin ala biləcəyi maksimum sahə: {arrayList.Capacity}");
            Console.WriteLine($"Elementlərin indexlə tapılması: {arrayList[0]}, {arrayList[1]}, {arrayList[2]}");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");

            arrayList.RemoveRange(1, 2); //Indexden bashlayaraq neche element silinecek onu yaziriq.
            arrayList.RemoveAt(0); //Sadece nechenci indexdeki element silinecek (1 eded) onu yaziriq.

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadKey();
        }
    }
}
