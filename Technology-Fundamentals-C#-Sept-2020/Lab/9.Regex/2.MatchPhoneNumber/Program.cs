using System;
using System.Text.RegularExpressions;

namespace _2.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:(?:^)|(?: ))\+359(( )|(-))2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);

            Console.WriteLine(string.Join(",", matches));
        }
    }
}
