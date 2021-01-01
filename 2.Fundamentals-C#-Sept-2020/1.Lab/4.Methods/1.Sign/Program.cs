using System;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            Sign(number1);
            
            }
        
        static void Sign (int number)
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
                else if (number<0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number 0 is zero.");
                }
        }
    }
}
