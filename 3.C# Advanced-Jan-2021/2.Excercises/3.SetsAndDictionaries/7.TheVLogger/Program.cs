using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> logger = new Dictionary<string, List<string>>();
            Dictionary<string, int> followings = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmd = command.Split();
                string vlogger = cmd[0];
                string action = cmd[1];
                string target = cmd[2];

                if (action == "joined")
                {
                    if (!logger.ContainsKey(vlogger))
                    {
                        logger[vlogger] = new List<string>();
                        followings[vlogger] = 0;
                    }
                }
                else
                {
                    if (logger.ContainsKey(vlogger) && logger.ContainsKey(target))
                    {
                        if (vlogger != target && !logger[target].Contains(vlogger))
                        {
                            logger[target].Add(vlogger);
                            followings[vlogger]++;
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {logger.Keys.Count} vloggers in its logs.");

            int maxFollowers = 0;
            string mostFamous = "";
            foreach (var item in logger)
            {
                if (item.Value.Count > maxFollowers
                    || (item.Value.Count == maxFollowers && followings[item.Key] < followings[mostFamous]))
                {
                    maxFollowers = item.Value.Count;
                    mostFamous = item.Key;
                }
            }

            Console.WriteLine($"1. {mostFamous} : {logger[mostFamous].Count} followers, {followings[mostFamous]} following");

            if (logger[mostFamous].Count != 0) //in case the vlogger has no followers, print just the first line
            {
                foreach (var item in logger[mostFamous].OrderBy(x=>x))
                {
                    Console.WriteLine($"* {item}");
                }
            }
        }
    }
}
