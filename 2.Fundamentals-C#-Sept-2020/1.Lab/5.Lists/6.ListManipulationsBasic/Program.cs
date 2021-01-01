using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulationsBasic
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
            
            while (command[0].ToUpper() != "END")
            {
                int comOne = int.Parse(command[1]);
                
                switch (command[0].ToUpper())
                {
                    case "ADD": input.Add(comOne); break;
                    case "REMOVE": input.Remove(comOne); break;
                    case "REMOVEAT": input.RemoveAt(comOne); break;
                    case "INSERT": input.Insert(int.Parse(command[2]), comOne); break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
