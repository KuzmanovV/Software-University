using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            List<double> second = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            List<double> result = new List<double>();

            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count>second.Count)
            {
                for (int i = second.Count; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else if (first.Count < second.Count)
            {
                for (int i = first.Count; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
