using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int S = inputCommands[1];
            int X = inputCommands[2];
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (!queue.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
