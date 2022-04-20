using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = input =>
            {
                int min = int.MaxValue;

                foreach (var n in input)
                {
                    if (n < min)
                    {
                        min = n;
                    }
                }

                return min;
            };

            Console.WriteLine(minFunc(input));
        }
    }
}
