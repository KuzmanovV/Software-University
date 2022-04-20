using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cubes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Mort")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int value = int.Parse(cmdArgs[1]);

                switch (cmdArgs[0])
                {
                    case "Add":
                        cubes.Add(value);
                        break;
                    case "Remove":
                        cubes.Remove(value);
                        break;
                    case "Replace":
                        int index = cubes.FindIndex(x => x == value);
                        cubes[index] = int.Parse(cmdArgs[2]);
                        break;
                    case "Collapse":
                        cubes.RemoveAll(x => x < value);
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', cubes));
        }
    }
}
