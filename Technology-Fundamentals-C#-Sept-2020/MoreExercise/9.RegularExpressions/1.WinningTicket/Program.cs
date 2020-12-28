using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressionsME
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)// for every ticket in the input
            {
                string trimmed = input[i].Trim();

                if (trimmed.Length==20)            //checking validity of the ticket
                {
                    string firstHalf = "";          //splitting ticket into 2 halfs
                    string secondHalf = "";
                    int counter = 0;

                    foreach (var ch in trimmed)
                    {
                        if (counter < 10)
                        {
                            firstHalf += ch;
                        }
                        else
                        {
                            secondHalf += ch;
                        }

                        counter++;
                    }

                    string patternWiner = @"([@#$^]{6,10})";       //checking for winner
                    Regex regexWiner = new Regex(patternWiner);
                    Match matchWinerfirst = regexWiner.Match(firstHalf);
                    Match matchWinerSecond = regexWiner.Match(secondHalf);

                    if (matchWinerfirst.Success && matchWinerfirst.Groups[1].Value==matchWinerSecond.Groups[1].Value 
                        && matchWinerfirst.Groups[1].Value.Length<10)      //winner 6-9
                    {
                        Console.WriteLine($"ticket \"{trimmed}\" - " +
                            $"{matchWinerfirst.Groups[1].Value.Length}{matchWinerfirst.Groups[1].Value[0]}");
                    }
                    else if (matchWinerfirst.Success && matchWinerfirst.Groups[1].Value == matchWinerSecond.Groups[1].Value
                        && matchWinerfirst.Groups[1].Value.Length == 10)                              //winner Jackpot
                    {
                        Console.WriteLine($"ticket \"{trimmed}\" - " +
                            $"10{matchWinerfirst.Groups[1].Value[0]} Jackpot!");
                    }                                           //not a winner
                    else
                    {
                        Console.WriteLine($"ticket \"{trimmed}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
