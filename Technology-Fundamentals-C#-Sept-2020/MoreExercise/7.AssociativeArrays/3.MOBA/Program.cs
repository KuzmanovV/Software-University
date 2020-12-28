using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> pool = new Dictionary<string, Dictionary<string, int>>();
            
            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] tokens = input.Split(new[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries);
                string player = tokens[0];

                if (tokens.Length == 3)     //pool input
                {
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (!pool.ContainsKey(player))
                    {
                        pool.Add(player, new Dictionary<string, int>());
                        pool[player][position] = skill;
                    }
                    else
                    {
                        if (!pool[player].ContainsKey(tokens[1]))
                        {
                            pool[player][position] = skill;
                        }
                        else
                        {
                            if (pool[player][position] < skill)
                            {
                                pool[player][position] = skill;
                            }
                        }
                    }
                }
                else                     //command input
                {
                    string playerNext = tokens[1];

                    if (pool.ContainsKey(player) && pool.ContainsKey(playerNext))
                    {
                        string toRemove = "";
                        
                        foreach (var item in pool[player])
                        {
                            if (pool[playerNext].ContainsKey(item.Key))
                            {
                                if (pool[player][item.Key]>pool[playerNext][item.Key])
                                {
                                    toRemove = playerNext;
                                }
                                else if (pool[player][item.Key] < pool[playerNext][item.Key])
                                {
                                    toRemove = player;
                                }
                            }
                        }

                        if (toRemove!="")
                        {
                            pool.Remove(toRemove);
                        }
                    }
                }
            }

            foreach (var item in pool.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var skill in item.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}
