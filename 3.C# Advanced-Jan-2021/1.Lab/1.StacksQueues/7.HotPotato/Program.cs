using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int counter = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);

            string hot = "";
           
            while (queue.Count>1)
            {
                for (int i = 0; i < counter-1; i++)
                {
                    hot = queue.Dequeue();
                    queue.Enqueue(hot);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
