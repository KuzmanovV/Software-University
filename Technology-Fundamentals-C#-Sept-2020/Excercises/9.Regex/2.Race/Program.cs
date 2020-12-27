using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> rating = new Dictionary<string, int>();

            foreach (var item in participants)
            {
                rating.Add(item, 0);
            }

            string input;

            string patternName = @"[\W\d]";
            string patternDistance = @"[A-Za-z\W]";

            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = Regex.Replace(input, patternName, "");
                string distance = Regex.Replace(input, patternDistance, "");
                int summedDistance = 0;

                foreach (var ch in distance)
                {
                    summedDistance += int.Parse(ch.ToString());
                }
                
                if (participants.Contains(name))
                {
                    rating[name] += summedDistance;
                }
            }

            int counter = 0;

            foreach (var kvp in rating.OrderByDescending(x => x.Value))
            {
                counter++;

                switch (counter)
                {
                    case 1: Console.WriteLine($"1st place: {kvp.Key}"); break;
                    case 2: Console.WriteLine($"2nd place: {kvp.Key}"); break;
                    case 3: Console.WriteLine($"3rd place: {kvp.Key}"); break;
                    default: break;
                }
            }
        }
    }
}
