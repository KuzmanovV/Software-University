using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[2] == "going!")
                {
                    if (!guests.Contains(command[0]))
                    {
                        guests.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
