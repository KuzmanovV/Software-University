using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@[A-Za-z]{3,}@@[A-Za-z]{3,}@)|(#[A-Za-z]{3,}##[A-Za-z]{3,}#)";

            string input = Console.ReadLine();
            
            var matches = Regex.Matches(input, pattern);

            List<string> output = new List<string>();
            int mirrorCount = 0;
            int pairsCount = 0;

            foreach (Match item in matches)
            {
                string secondHalf = item.Value.Substring((item.Value.Length)/2);
                string firstHalf = item.Value.Substring(0, (item.Value.Length)/2);
                
                char[] ch = secondHalf.ToCharArray();
                Array.Reverse(ch);
                string invertedSecondHalf = new string(ch);

                if (matches.Count>0)
                {
                    if (firstHalf==invertedSecondHalf)
                    {
                        output.Add(firstHalf.Substring(1, firstHalf.Length - 2) 
                            + " <=> " + secondHalf.Substring(1, secondHalf.Length - 2));
                        mirrorCount++;
                    }
                    
                    pairsCount++;
                }
            }

            if (pairsCount==0)
            {
                    Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairsCount} word pairs found!");
            }

            if (mirrorCount==0)
            {
                        Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", output));
            }
        }
    }
}
