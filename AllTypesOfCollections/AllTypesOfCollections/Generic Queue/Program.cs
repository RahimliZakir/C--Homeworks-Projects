using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Mən");
            queue.Enqueue("Sən");
            queue.Enqueue("O");

            //Sondan elave edir elementleri.

            Console.WriteLine($"Queue'in uzunluğu: {queue.Count}");

            Console.WriteLine("-------------------------------------------------");

            foreach (var neo in queue)
            {
                Console.WriteLine(neo);
            }

            Console.WriteLine("-------------------------------------------------");

            queue.Dequeue(); //FIFO //Onden goturur elementleri.

            foreach (var oen in queue)
            {
                Console.WriteLine(oen);
            }

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine( queue.Peek()); //Queuenin en yuxarisindaki elementi qaytarir, lakin silmir.

            Console.WriteLine("-------------------------------------------------");

            foreach (var oen in queue)
            {
                Console.WriteLine(oen);
            }

            Console.ReadKey();
        }
    }
}
