using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.SumAdjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> adjacent = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            for (int i = 0; i < adjacent.Count - 1; i++)
            {
                if (adjacent[i] == adjacent[i + 1])
                {
                    adjacent[i] += adjacent[i + 1];
                    adjacent.RemoveAt(i + 1);
                    i = -1;
                }
            }
            
            Console.WriteLine(string.Join(" ", adjacent));
        }                

    }
}
