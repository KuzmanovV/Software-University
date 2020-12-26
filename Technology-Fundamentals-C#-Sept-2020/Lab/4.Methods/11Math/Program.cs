using System;

namespace _11Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();
            double last = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Operation(first, mathOperator, last):f2}");
        }

        private static double Operation(double first, string mathOperator, double last)
        {
            switch (mathOperator)
            {
                case "/": return first / last; break;
                case "*": return first * last; break;
                case "+": return first + last; break;
                default: return first - last; break;
            }
        }
    }
}
