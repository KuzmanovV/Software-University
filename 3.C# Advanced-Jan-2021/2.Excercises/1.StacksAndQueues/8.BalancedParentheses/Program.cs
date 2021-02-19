using System;
using System.Collections;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool negative = false;
            foreach (char c in input)
            {
                if (c != '(' && c != '[' && c != '{')
                {
                    if (stack.Count>0)
                    {
                    switch (c)
                    {
                        case ')':
                            if (stack.Pop()!='(')
                            {
                                Console.WriteLine("NO");
                                negative = true;
                                break;
                            }
                            break;
                        case ']':
                            if (stack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                negative = true;
                                break;
                            }
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                negative = true;
                                break;
                            }
                            break;
                        default:
                            break;
                    }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        negative = true;
                        break;
                    }

                    if (negative)
                    {
                        break;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }


            if (!negative)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
