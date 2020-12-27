using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (first.Count > 0 && second.Count > 0)
            {
                int contFirst = first[0];
                int contSecond = second[0];


                if (first[0] > second[0])
                {
                    first.Add(contFirst);
                    first.Add(contSecond);
                }
                else if (first[0] < second[0])
                {
                    second.Add(contSecond);
                    second.Add(contFirst);
                }

                first.RemoveAt(0);
                second.RemoveAt(0);
            }

            if (first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}
