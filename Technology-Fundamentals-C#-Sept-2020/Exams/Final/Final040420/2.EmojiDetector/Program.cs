using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternEmoji = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";

            string patternNumbers = @"\d";

            var matchesEmoji = Regex.Matches(input, patternEmoji);

            long treshold = 1;

            foreach (Match item in Regex.Matches(input, patternNumbers))
            {
                treshold *= long.Parse(item.Value);
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");

            Dictionary<string, long> emojis = new Dictionary<string, long>();

            foreach (Match item in matchesEmoji)
            {
                emojis[item.Value] = 0;
                string emoji = item.Value;

                foreach (char ch in emoji.Substring(2, emoji.Length-3))
                {
                    emojis[item.Value] += ch;
                }
            }

            foreach (var item in emojis.Where(x=>x.Value>=treshold))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
