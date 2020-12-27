using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {',',' ' }, StringSplitOptions.RemoveEmptyEntries);

            //TD trim empty spaces!


            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();

            string pattern = @"[^0-9+\-\/\*\.]";
            string patternDamage = @"[-+]?[0-9]+\.?[0-9]*";

            foreach (var demon in input)
            {
                int health = 0;
                double damage = 0;
                MatchCollection matchCollection = Regex.Matches(demon, pattern);
                MatchCollection matchCollectionDamage = Regex.Matches(demon, patternDamage);

                if (matchCollection.Count > 0)
                {
                    foreach (var item in matchCollection)
                    {
                        health += (int)item.ToString().ToCharArray()[0];
                    }
                }

                if (matchCollectionDamage.Count > 0)
                {
                    foreach (Match item in matchCollectionDamage)
                    {
                        damage += double.Parse(item.Value);
                    }
                }

                foreach (char ch in demon)
                {
                    if (ch == '*')
                    {
                        damage *= 2.0;
                    }

                    if (ch == '/')
                    {
                        damage /= 2.0;
                    }
                }

                demons[demon] = new List<double> { health, damage };
            }

            foreach (var item in demons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        }
    }
}
