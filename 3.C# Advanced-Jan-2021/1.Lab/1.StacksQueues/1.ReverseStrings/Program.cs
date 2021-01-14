using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input);
            string output="";

            while(stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
