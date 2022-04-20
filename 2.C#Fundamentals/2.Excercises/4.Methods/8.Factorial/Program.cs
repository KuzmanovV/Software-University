using System;

namespace _8.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Factorial(first)*1.0 / Factorial(last):f2}");
        }

        private static long Factorial(long first)
        {
            long fact = 1;
            for (int i = 1; i <= first; i++)
            {
                fact *= i;
            }

            return fact;
            
        }
    }
}
