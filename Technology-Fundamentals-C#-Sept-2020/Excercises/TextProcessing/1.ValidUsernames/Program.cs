﻿using System;
using System.Linq;
using System.Text;

namespace ExcTextProc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in input)
            {
                if (word.Length > 3
                    && word.Length < 16
                    && word.All(x => char.IsLetterOrDigit(x)
                    || word.Contains("-") || word.Contains("_")))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
