using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = inputCommands[0];
            int S = inputCommands[1];
            int X = inputCommands[2];

            Stack<int> stack = new Stack<int>(inputData);

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
