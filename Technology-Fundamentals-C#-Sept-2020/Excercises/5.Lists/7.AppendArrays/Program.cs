using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                            .Split("|")
                            .ToList();

            List<string> output = new List<string>();
            
            for (int i = 0; i < input.Count; i++)
            {
                List<string> small = input[input.Count - 1 - i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                output.AddRange(small);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
