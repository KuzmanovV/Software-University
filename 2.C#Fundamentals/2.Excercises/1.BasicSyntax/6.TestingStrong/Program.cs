using System;

namespace _6.TestingStrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int currentNumber = 0;
            int sum = 0;

            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;

                int factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
