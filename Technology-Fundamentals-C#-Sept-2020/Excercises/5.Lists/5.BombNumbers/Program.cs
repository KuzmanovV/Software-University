using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double[] bombs = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToArray();

            for (int i = 0; i < input.Count; i++)
            {
                int bombIndex = input.IndexOf(bombs[0]);
                if (bombIndex >= 0)
                {
                    int startIndex = bombIndex - (int)bombs[1];
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    int endIndex = bombIndex + (int)bombs[1];
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(input.Sum());
        }
    }
}
