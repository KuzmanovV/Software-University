using System;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digit = 0;
                int sum = 0;
                int number = i;

                while (number != 0)
                {
                    digit = number % 10;
                    sum += digit;
                    number /= 10;
                }
                                    
                bool isNumberSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isNumberSpecial}");
            }
 
        }
    }
}
