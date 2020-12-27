using System;

namespace Methods_E
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            PrintSmallest(first, second, third);
        }

        private static void PrintSmallest(int first, int second, int third)
        {
            int output = Math.Min(Math.Min(first, second), third);
            Console.WriteLine(output);
        }
    }
}
