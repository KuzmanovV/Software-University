using System;
using System.Text.RegularExpressions;

namespace _3.BarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.\d]*(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);

            double total = 0.0;
            string input;

            while ((input = Console.ReadLine())!= "end of shift")
            {
                Match match = regex.Match(input);
                
                if (match.Success)
                {
                    int qty = int.Parse(match.Groups[3].ToString());
                    double price = double.Parse(match.Groups[4].ToString());
                    total += qty * price;
                    
                    Console.WriteLine($"{match.Groups[1]}: {match.Groups[2]} - {qty*price:f2}");
                }
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
