using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                elements.Add(input[j]);
                }
            }

            foreach (var item in elements.OrderBy(x=>x))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
