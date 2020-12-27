using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            string command = Console.ReadLine().ToLower();
            List<string> instructions = new List<string>(2);

            while (command != "end")
            {
                instructions = command
                    .Split()
                    .ToList();

                if (instructions[0] == "delete")
                {
                    input.RemoveAll(n => n == int.Parse(instructions[1]));
                }
                else
                {
                    input.Insert(int.Parse(instructions[2]), int.Parse(instructions[1]));
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
