using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<HashSet<string>>> vloggers = new Dictionary<string, List<HashSet<string>>>();

            string command;

            while ((command = Console.ReadLine())!= "Statistics")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vlogger = cmd[0];
                string followed = cmd[2];

                if (cmd.Length>3)   //joined
                {
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers[vlogger] = new List<HashSet<string>>();
                    }

                    vloggers[vlogger].Add(new HashSet<string>());
                    vloggers[vlogger].Add(new HashSet<string>());
                }
                else
                {
                    if (vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(followed) && vlogger!=followed)
                    {
                        vloggers[followed][0].Add(vlogger);
                        vloggers[vlogger][1].Add(followed);
                    }
                }
            }

            int counter = 0;
            foreach (var item in vloggers.OrderByDescending(x=>x.Value[0].Count).ThenBy(y=>y.Value[1].Count))
            {
                counter++;
                if (counter==1)
                {
                    Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
                    Console.WriteLine($"{counter}. {item.Key} : {item.Value[0].Count} followers, " +
                    $"{item.Value[1].Count} following");

                    foreach (var follower in item.Value[0].OrderBy(x=>x))
                    {
                        Console.WriteLine($"* {follower}");
                    }
                }
                else
                {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value[0].Count} followers, " +
                    $"{item.Value[1].Count} following");
                }
            }
        }
    }
}
