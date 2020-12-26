using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (var word in input)
            {
                string lWord = word.ToLower();
                if (output.ContainsKey(lWord))
                {
                    output[lWord]++;
                }
                else
                {
                    output.Add(lWord, 1);
                }
            }

            foreach (var lWord in output)
            {
                if (lWord.Value%2==1)
                {
                    Console.Write($"{lWord.Key} ");
                }      
            }
        }
    }
}
