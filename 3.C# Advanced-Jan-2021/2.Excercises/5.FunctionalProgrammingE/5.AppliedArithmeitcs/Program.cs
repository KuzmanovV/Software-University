using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.AppliedArithmeitcs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(input);
                }
                else
                {
                    input = input.Select(GetArithmeticFunc(command)).ToList();
                }
            }
        }

        static Func<int, int> GetArithmeticFunc(string command)
        {
            Func<int, int> arithmeticFunc;
            
            switch (command)
            {
                case "add": return arithmeticFunc = n => n + 1;
                case "multiply": return arithmeticFunc = n => n * 2;
                case "subtract": return arithmeticFunc = n => n - 1;
                default: return arithmeticFunc = n=>n;
            }
        }
    }
}
