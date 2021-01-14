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

            Stack<char> stack = new Stack<char>(input.Substring(0,input.Length/2));
            Queue<char> queue = new Queue<char>(input.Substring(input.Length/2));
            bool isBalanced = true;

            while (stack.Count!=0)
            {
                switch (stack.Pop())
                {
                    case '(':
                        if (queue.Dequeue()!=')')
                        {
                            isBalanced = false;
                        }
                        break;
                    case '[':
                        if (queue.Dequeue()!=']')
                        {
                            isBalanced = false;
                        }
                        break;
                    case '{':
                        if (queue.Dequeue()!='}')
                        {
                            isBalanced = false;
                        }
                        break;
                    
                    default:
                        break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
