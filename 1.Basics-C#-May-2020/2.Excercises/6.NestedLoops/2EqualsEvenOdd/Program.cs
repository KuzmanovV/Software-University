using System;

namespace _2EqualsEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            for (int i = s; i <= e; i++)
            {
                int oddSum = 0;
                int evenSum = 0;

                int number = i;
                    
                    while (number>0)
                    {
                    evenSum += number % 10;
                    number /= 10;
                    oddSum += number % 10;
                    number /= 10;
                    }

                if (evenSum==oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
