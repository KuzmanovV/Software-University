using System;
using System.Collections.Generic;

namespace _4.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> output = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {

                {
                    string[] cmd = Console.ReadLine().Split(" ");

                    if (!output.ContainsKey(cmd[0]))
                    {
                        output.Add(cmd[0], new Dictionary<string, List<string>>());
                        output[cmd[0]][cmd[1]] = new List<string>() { cmd[2] };
                    }
                    else
                    {
                        if (!output[cmd[0]].ContainsKey(cmd[1]))
                        {
                            output[cmd[0]].Add(cmd[1], new List<string>() { cmd[2] });
                        }
                        else
                        {
                            output[cmd[0]][cmd[1]].Add(cmd[2]);
                        }
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
