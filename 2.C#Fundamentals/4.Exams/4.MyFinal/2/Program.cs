using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string output = match.Groups[2].Value + match.Groups[3].Value + match.Groups[4].Value + match.Groups[5].Value;
                    Console.WriteLine($"Password: {output}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
