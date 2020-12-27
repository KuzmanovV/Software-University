using System;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:(?:^)|(?:\s))(?<mail>[A-Za-z0-9]+[\w\.\-]*[A-Za-z0-9]+\@[A-Za-z\-]+(?:\.[A-Za-z\-]+)+)";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
