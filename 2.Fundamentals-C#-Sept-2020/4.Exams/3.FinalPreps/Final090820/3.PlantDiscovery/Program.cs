using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> rarity = new Dictionary<string, double>();
            Dictionary<string, List<int>> ratings = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                if (!rarity.ContainsKey(input[0]))
                {
                    rarity.Add(input[0], 0);
                    ratings.Add(input[0], new List<int>());
                }

                rarity[input[0]] = int.Parse(input[1]);
            }

            string command;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmd = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Rate":
                        string[] tokensRate = cmd[1].Split(" - ");

                        if (ratings.ContainsKey(tokensRate[0]) && int.Parse(tokensRate[1]) > 0)
                        {
                            ratings[tokensRate[0]].Add(int.Parse(tokensRate[1]));
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "Update":
                        string[] tokensUpdate = cmd[1].Split(" - ");

                        if (rarity.ContainsKey(tokensUpdate[0]))
                        {
                            rarity[tokensUpdate[0]] = int.Parse(tokensUpdate[1]);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "Reset":

                        if (ratings.ContainsKey(cmd[1]))
                        {
                            ratings[cmd[1]] = new List<int>() { 0 };
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            foreach (var item in rarity)
            {
                output.Add(item.Key, new List<double>() { item.Value });

                if (ratings[item.Key].Count > 0)
                {
                    output[item.Key].Add(ratings[item.Key].Average());
                }
                else
                {
                    output[item.Key].Add(0);
                }
            }

            foreach (var item in output.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
