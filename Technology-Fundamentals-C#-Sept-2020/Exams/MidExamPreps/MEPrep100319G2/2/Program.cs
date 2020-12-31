using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('#', StringSplitOptions.RemoveEmptyEntries).ToList();
            int water = int.Parse(Console.ReadLine());
            double efford = 0;
            int totalFire = 0;
            Console.WriteLine("Cells:");

            for (int i = 0; i < input.Count; i++)
            {
                string[] cell = input[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                bool isValid = false;
                int range = int.Parse(cell[1]);
                switch (cell[0])
                {
                    case "High":
                        if (range > 80 && range <= 125)
                        {
                            isValid = true;
                        }
                        break;
                    case "Medium":
                        if (range > 50 && range < 81)
                        {
                            isValid = true;
                        }
                        break;
                    case "Low":
                        if (range > 0 && range < 51)
                        {
                            isValid = true;
                        }
                        break;
                    default:
                        break;
                }

                if (isValid && water>=range)
                {
                    water -= range;
                    efford += .25 * range;
                    Console.WriteLine($" - {range}");
                    totalFire += range;
                }
            }

            Console.WriteLine($"Effort: {efford:f2}\nTotal Fire: {totalFire}");
        }
    }
}
