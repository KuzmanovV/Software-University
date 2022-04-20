using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gauss = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            int maxIndex = gauss.Count / 2;
            
            for (int i = 0; i < maxIndex; i++)
            {
                gauss[i] += gauss[gauss.Count - 1];
                gauss.RemoveAt(gauss.Count - 1);
            }

            Console.WriteLine(string.Join(" ", gauss));
        }
    }
}
