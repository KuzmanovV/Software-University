using System;
using System.Collections.Generic;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> numbers = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (!numbers.ContainsKey(input))
                {
                    numbers[input] = 0;
                }

                numbers[input]++;
            }

            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }

            }
        }
    }
}
