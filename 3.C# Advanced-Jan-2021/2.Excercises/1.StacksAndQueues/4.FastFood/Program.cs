using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQty = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int forService = 0;
            int max = int.MinValue;
            
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);

                if (orders[i]>max)
                {
                    max = orders[i];
                }
            }

            Console.WriteLine(max);

            for (int i = 0; i < orders.Length; i++)
            {
                forService = queue.Peek();

                if (forService <= foodQty)
                {
                    foodQty -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (foodQty >= 0 && queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: ");

                int forCount = queue.Count;
                for (int i = 0; i < forCount; i++)
                {
                    Console.Write(queue.Dequeue());
                }
            }
        }
    }
}
