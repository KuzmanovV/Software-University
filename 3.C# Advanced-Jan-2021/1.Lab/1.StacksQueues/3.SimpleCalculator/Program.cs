using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            int output = int.Parse(stack.Pop());

            while (stack.Count!=0)
            {
                switch (stack.Pop())
                {
                    case "+":
                        output += int.Parse(stack.Pop());
                        break;
                    case "-":
                        output -= int.Parse(stack.Pop());
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
