using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> output = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individuals = new Dictionary<string, int>();

            string command;
            
            int first = 0;
            bool isFirstIteration = true;
            bool areEquals = true; ;

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] cmd = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string user = cmd[0];
                string contest = cmd[1];
                int points = int.Parse(cmd[2]);

                if (isFirstIteration)
                {
                    first = points;
                    isFirstIteration = false;
                }

                if (!individuals.ContainsKey(user))
                {
                    individuals.Add(user, points);
                }
                else
                {
                    if (output[contest].ContainsKey(user) && points > individuals[user])
                    {
                        individuals[user] = points;
                    }
                    else if (!output[contest].ContainsKey(user))
                    {
                        individuals[user] += points;
                    }
                }

                if (!output.ContainsKey(contest))
                {
                    output.Add(contest, new Dictionary<string, int>());
                    output[contest][user] = points;
                }
                else
                {
                    if (!output[contest].ContainsKey(user))
                    {
                        output[contest][user] = points;
                    }
                    else
                    {
                        if (points > output[contest][user])
                        {
                            output[contest][user] = points;
                        }
                    }
                }

                if (first != individuals[user])
                {
                    areEquals = false;
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");

                int ind = 0;

                foreach (var usern in item.Value.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
                {
                    ind++;
                    Console.WriteLine($"{ind}. {usern.Key} <::> {usern.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int index = 0;

            if (areEquals)
            {
                foreach (var item in individuals)
                {
                    index++;
                    Console.WriteLine($"{index}. {item.Key} -> {item.Value}");
                }
            }
            else
            {
                foreach (var item in individuals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    index++;
                    Console.WriteLine($"{index}. {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
