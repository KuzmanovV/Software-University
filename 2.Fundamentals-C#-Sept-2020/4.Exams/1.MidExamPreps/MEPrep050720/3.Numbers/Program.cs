using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            input.Sort();
            input.Reverse();
            double average = input.Average();

            List<int> output = input.Where(x => x > average).ToList();

            if (output.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{output[i]} ");
                }
            }
            else if (output.Count<5 && output.Count>0)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    Console.Write($"{output[i]} ");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
