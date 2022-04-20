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

            int forService = 0;
            
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(queue.Max());

            int forCount = queue.Count;
            for (int i = 0; i < forCount; i++)
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

            if (foodQty >= 0 && !queue.Any())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
