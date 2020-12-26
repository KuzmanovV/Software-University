using System;
using System.Text.RegularExpressions;

namespace _3.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>(0[1-9])|([1-2][0-9])|(3[0-1]))([-.\/])(?<month>[A-Z][a-z]{2})\4(?<year>\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}
