using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Onden elave edir elementleri.

            Console.WriteLine($"Stack'in uzunluğu: {stack.Count}.");

            Console.WriteLine("-----------------------------------------------------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------");

            stack.Pop(); //LIFO //Onden goturur elementleri.

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine(stack.Peek()); //Stackin en yuxarisinda yerleshen elementi, qaytarir lakin silmir.

            Console.WriteLine("-----------------------------------------------------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
