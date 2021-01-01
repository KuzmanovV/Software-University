using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == -0)
                {
                    Console.WriteLine("-0 => -0");
                }
                else
                {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");

                }


            }
        }
    }
}
