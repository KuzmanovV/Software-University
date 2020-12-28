using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine()
                            .Split()
                            .Select(decimal.Parse)
                            .ToList();

            decimal timeLeft = 0;
            for (int i = 0; i < input.Count/2; i++)
            {
                timeLeft += input[i];

                if (input[i] == 0)
                {
                    timeLeft = timeLeft*80/100;
                }
            }
            
            decimal timeRight = 0;
            for (int i = input.Count-1; i >= input.Count/2; i--)
            {
                timeRight += input[i];

                if (input[i] == 0)
                {
                    timeRight = timeRight * 80 / 100;
                }
            }

            if (timeLeft<timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");
            }
            else if (timeRight<timeLeft)
            {
                Console.WriteLine($"The winner is right with total time: {timeRight}");
            }
        }
    }
}
