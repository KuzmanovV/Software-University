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
                        if (stack.Count > 0)
                        {
                            int max = int.MinValue;

                            int forCounter = stack.Count;
                            for (int j = 0; j < forCounter; j++)
                            {
                                int current = stack.Peek();

                                if (max < current)
                                {
                                    max = current;
                                }

                                stackContainer.Push(stack.Pop());
                            }

                            int backForCounter = stackContainer.Count;
                            for (int j = 0; j < backForCounter; j++)
                            {
                                stack.Push(stackContainer.Pop());
                            }

                            Console.WriteLine(max);
                        }
                        break;
                    case "4": //print min
                        if (stack.Count > 0)
                        {
                            int min = int.MaxValue;

                            int forCounter = stack.Count;
                            for (int j = 0; j < forCounter; j++)
                            {
                                int current = stack.Peek();

                                if (min > current)
                                {
                                    min = current;
                                }

                                stackContainer.Push(stack.Pop());
                            }

                            int backForCounter = stackContainer.Count;
                            for (int j = 0; j < backForCounter; j++)
                            {
                                stack.Push(stackContainer.Pop());
                            }

                            Console.WriteLine(min);
                        }
                        break;
                    default:
                        int[] cmd = command.Split().Select(int.Parse).ToArray();
                        stack.Push(cmd[1]);
                        break;
                }
            }

            int forCounterLast = stack.Count;
            for (int i = 0; i < forCounterLast-1; i++)
            {
                Console.Write(stack.Pop());
                Console.Write(", ");
            }
            Console.Write(stack.Pop());
        }
    }
}
