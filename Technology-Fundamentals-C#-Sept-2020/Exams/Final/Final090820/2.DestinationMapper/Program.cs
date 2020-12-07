using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();
            List<string> output = new List<string>();

            var matches = Regex.Matches(input, pattern);

            int points = 0;

            foreach (Match match in matches)
            {
                points += match.ToString().Length - 2;
                output.Add(match.Groups[2].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", output)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
