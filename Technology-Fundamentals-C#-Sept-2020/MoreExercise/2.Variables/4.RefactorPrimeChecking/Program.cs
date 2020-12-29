using System;

namespace _4.RefactorPrimeChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                string isPrime = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
