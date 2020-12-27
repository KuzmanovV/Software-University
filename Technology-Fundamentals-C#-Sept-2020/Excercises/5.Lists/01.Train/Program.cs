using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine().ToLower();
            List<string> instructions = new List<string>(2);

            while (command != "end")
            {
                instructions = command
                    .Split()
                    .ToList();

                if (instructions[0] == "add")
                {
                    train.Add(int.Parse(instructions[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + int.Parse(instructions[0]) <= capacity)
                        {
                            train[i] += int.Parse(instructions[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
