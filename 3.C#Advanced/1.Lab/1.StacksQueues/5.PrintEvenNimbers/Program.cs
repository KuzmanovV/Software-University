using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNimbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", queue.ToList()));
        }
    }
}
