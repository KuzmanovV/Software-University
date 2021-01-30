using System;
using System.Linq;

namespace _4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Select(x => x * 1.2d).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
