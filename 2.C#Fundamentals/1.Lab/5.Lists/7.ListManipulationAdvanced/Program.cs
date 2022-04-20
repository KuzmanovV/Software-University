using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();

            bool isChanged = false;

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD": input.Add(int.Parse(command[1])); isChanged = true; break;
                    case "REMOVE": input.Remove(int.Parse(command[1])); isChanged = true; break;
                    case "REMOVEAT": input.RemoveAt(int.Parse(command[1])); isChanged = true; break;
                    case "INSERT": input.Insert(int.Parse(command[2]), int.Parse(command[1])); isChanged = true; break;
                    case "CONTAINS": Console.WriteLine(input.Contains(int.Parse(command[1])) ? "Yes" : "No such number"); break;
                    case "PRINTEVEN": Console.WriteLine(string.Join(" ", input.Where(n => n % 2 == 0))); break;
                    case "PRINTODD": Console.WriteLine(string.Join(" ", input.Where(n => n % 2 != 0))); break;
                    case "GETSUM": Console.WriteLine(input.Sum()); break;
                    case "FILTER":
                        switch (command[1])
                        {
                            case "<": Console.WriteLine(string.Join(" ", input.Where(n => n < int.Parse(command[2])))); break;
                            case ">": Console.WriteLine(string.Join(" ", input.Where(n => n > int.Parse(command[2])))); break;
                            case ">=": Console.WriteLine(string.Join(" ", input.Where(n => n >= int.Parse(command[2])))); break;
                            case "<=": Console.WriteLine(string.Join(" ", input.Where(n => n <= int.Parse(command[2])))); break;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
