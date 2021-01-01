using System;

namespace _6.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int storedNumber = number;
            int lastDigit = 0;
            int accumulated = 0;

            while (number != 0)
            {
                lastDigit = number % 10;

                for (int i = lastDigit-1; i > 0; i--)
                {
                    lastDigit *= i;
                }
                
                accumulated += lastDigit;
                number /= 10;
            }

            if (storedNumber != accumulated)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
