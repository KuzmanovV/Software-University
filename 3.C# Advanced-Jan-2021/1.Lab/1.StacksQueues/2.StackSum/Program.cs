using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            string command;
            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] cmd = command.Split();

                switch (cmd[0].ToUpper())
                {
                    case "ADD":
                        stack.Push(int.Parse(cmd[1]));
                        stack.Push(int.Parse(cmd[2]));
                        break;
                    case "REMOVE":
                        if (int.Parse(cmd[1]) <= stack.Count)
                        {
                            for (int i = 1; i <= int.Parse(cmd[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
