using System;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @">>(\w+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);
            double total = 0.0;

            Console.WriteLine("Bought furniture:");

            while ((input = Console.ReadLine())!= "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine(match.Groups[1].Value);
                    total += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                }
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
