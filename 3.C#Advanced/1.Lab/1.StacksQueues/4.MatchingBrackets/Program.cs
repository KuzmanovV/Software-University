using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    indexes.Push(i);
                }
                else if (input[i]==')')
                {
                    string output = "";

                    for (int j = indexes.Pop(); j <= i; j++)
                    {
                        output += input[j];
                    }
                   
                    Console.WriteLine(output);
                }
            }
        }
    }
}
