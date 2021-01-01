using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<string> stack = new Stack<string>();
            string output="";

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                output += stack.Pop();
            }

            Console.WriteLine(output);
        }
    }
}
