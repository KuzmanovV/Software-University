using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, int> legendary = new Dictionary<string, int>();
            legendary["shards"] = 0;
            legendary["fragments"] = 0;
            legendary["motes"] = 0;

            bool obtained = false;

            while (!obtained)
            {
                for (int i = 1; i < input.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        string colected = input[i].ToLower();

                        if (colected != "shards" && colected != "fragments" && colected != "motes")
                        {
                            if (junk.ContainsKey(colected))
                            {
                                junk[colected] += int.Parse(input[i - 1]);
                            }
                            else
                            {
                                junk.Add(colected, int.Parse(input[i - 1]));
                            }
                        }
                        else
                        {
                            legendary[colected] += int.Parse(input[i - 1]);

                            if (legendary[colected] >= 250)
                            {
                                switch (colected)
                                {
                                    case "shards": Console.WriteLine($"Shadowmourne obtained!"); break;
                                    case "fragments": Console.WriteLine($"Valanyr obtained!"); break;
                                    case "motes": Console.WriteLine($"Dragonwrath obtained!"); break;
                                }
                                obtained = true;
                                legendary[colected] -= 250;

                                foreach (var item in legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                                {
                                    Console.WriteLine($"{item.Key}: {item.Value}");
                                }

                                foreach (var item in junk.OrderBy(x => x.Key))
                                {
                                    Console.WriteLine($"{item.Key}: {item.Value}");
                                }

                                break;
                            }
                        }
                    }
                }

                if (!obtained)
                {
                    input = Console.ReadLine().Split().ToList();
                }
            }
        }
    }
}
