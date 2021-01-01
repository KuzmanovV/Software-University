using System;
using System.Collections.Generic;

namespace _5.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parked = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                if (cmdArgs.Length>2)
                {
                    if (parked.ContainsKey(cmdArgs[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parked[cmdArgs[1]]}");
                    }
                    else
                    {
                        parked.Add(cmdArgs[1], cmdArgs[2]);
                        Console.WriteLine($"{cmdArgs[1]} registered {cmdArgs[2]} successfully");
                    }
                }
                else
                {
                    if (!parked.ContainsKey(cmdArgs[1]))
                    {
                        Console.WriteLine($"ERROR: user {cmdArgs[1]} not found");
                    }
                    else
                    {
                        parked.Remove(cmdArgs[1]);
                        Console.WriteLine($"{cmdArgs[1]} unregistered successfully");
                    }
                }
            }

            foreach (var item in parked)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
