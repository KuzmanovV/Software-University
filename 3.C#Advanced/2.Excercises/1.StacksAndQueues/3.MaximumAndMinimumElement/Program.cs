using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> stackContainer = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "2":
                        if (stack.Count>0)
                        {
                        stack.Pop();
                        }
                        break;
                    case "3"://print max
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4": //print min
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        int[] cmd = command.Split().Select(int.Parse).ToArray();
                        stack.Push(cmd[1]);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
