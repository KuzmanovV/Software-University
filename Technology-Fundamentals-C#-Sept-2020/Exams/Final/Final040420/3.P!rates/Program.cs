using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string city;

            while ((city = Console.ReadLine()) != "Sail")
            {
                string[] tokens = city.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (!cities.ContainsKey(tokens[0]))
                {
                    cities[tokens[0]] = new List<int>() { 0, 0 };
                }

                cities[tokens[0]][0] += int.Parse(tokens[1]);
                cities[tokens[0]][1] += int.Parse(tokens[2]);
            }

            string command;

            while ((command = Console.ReadLine())!="End")
            {
                string[] cmd = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string town = cmd[1];
                switch (cmd[0])
                {
                    case "Plunder":
                        int people = int.Parse(cmd[2]);
                        int gold = int.Parse(cmd[3]);
                        cities[town][0] -= people;
                        cities[town][1] -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (cities[town][0]<=0 || cities[town][1]<=0)
                        {
                            cities.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        gold = int.Parse(cmd[2]);

                        if (gold<0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            cities[town][1] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                        }
                        break;
                    default:
                        break;
                }
            }
            
            if (cities.Count>0)
                {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                
                foreach (var item in cities.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
                    {
                        Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                    }
                }
                else
                {
                    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                }
        }
    }
}
