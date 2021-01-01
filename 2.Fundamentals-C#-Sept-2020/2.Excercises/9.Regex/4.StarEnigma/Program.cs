using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[STARstar]";

            int n = int.Parse(Console.ReadLine());

            int attacked = 0;
            int destroyed = 0;
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                int key = matches.Count;

                StringBuilder decrypted = new StringBuilder();
                foreach (var ch in input)
                {
                    string decryptedSymbol = ((char)(ch - key)).ToString();
                    decrypted.Append(decryptedSymbol);
                }

                string patternDecrypted = @"@([A-Za-z]+)[^@\-!:>]*:\d+[^@\-!:>]*!([AD])![^@\-!:>]*->\d+";
                Regex regex = new Regex(patternDecrypted);
                Match match = regex.Match(decrypted.ToString());

                if (match.Success)
                {
                    switch (match.Groups[2].Value)
                    {
                        case "A":
                            attacked++;
                            string planetA = "-> " + match.Groups[1].Value;
                            attackedPlanets.Add(planetA);
                            break;
                        case "D":
                            destroyed++;
                            string planetD = "-> " + match.Groups[1].Value;
                            destroyedPlanets.Add(planetD);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked}");
            if (attacked > 0)
            {
                attackedPlanets.Sort();
                Console.WriteLine(string.Join("\n", attackedPlanets));
            }
            
            Console.WriteLine($"Destroyed planets: {destroyed}");
            if (destroyed > 0)
            {
                destroyedPlanets.Sort();
                Console.WriteLine(string.Join("\n", destroyedPlanets));
            }
        }
    }
}
