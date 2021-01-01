using System;
using System.Text.RegularExpressions;

namespace _2.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)([a-zA-Z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,5})\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            int calories = 0;

            foreach (Match match in matches)
            {
                calories += (int.Parse)(match.Groups[4].Value);
            }

            Console.WriteLine($"You have food to last you for: {calories / 2000} days!");
            
                foreach (Match match in matches)
                {
                    Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, " +
                        $"Nutrition: {match.Groups[4].Value}"); ;
                }
        }
    }
}
