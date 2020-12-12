using System;
using System.Collections.Generic;
using System.Linq;

namespace LabAssArr
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!counts.ContainsKey(input[i]))
                    {
                        counts.Add(input[i], 0);
                    }
                    
                    counts[input[i]]++;
                }

            }
            
            foreach (var letter in counts)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
