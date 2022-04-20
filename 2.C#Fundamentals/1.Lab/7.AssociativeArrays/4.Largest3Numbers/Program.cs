using System;
using System.Linq;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            if (input.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(' ', input));
            }
        }
    }
}
