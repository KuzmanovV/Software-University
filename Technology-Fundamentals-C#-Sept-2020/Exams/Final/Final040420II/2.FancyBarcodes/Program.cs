using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string group = "";
                    
                    for (int j = 2; j < match.Length-2; j++)
                    {
                        if (Char.IsNumber(input[j]))
                        {
                            group += input[j];
                        }
                    }

                    if (group=="")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
