using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            foreach (var item in box)
            {
                stack.Push(item);
            }

            int racksCount = 1;
            int clothOut = 0;
            int newRack = capacity;
            
            for (int i = 0; i < box.Length; i++)
            {
                clothOut = stack.Peek();

                if (clothOut<=newRack)
                {
                    newRack -= clothOut;
                    stack.Pop();
                }
                else
                {
                    newRack = capacity;
                    racksCount++;
                    if (stack.Count>0)
                    {
                        stack.Pop();
                        newRack -= clothOut;
                    }
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
