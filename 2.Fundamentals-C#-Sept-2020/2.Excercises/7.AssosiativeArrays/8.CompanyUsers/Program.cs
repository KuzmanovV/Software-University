using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine())!="End")
            {
                string[] cmdArgs = command.Split(" -> ");

                if (!companies.ContainsKey(cmdArgs[0]))
                {
                    companies.Add(cmdArgs[0], new List<string> { cmdArgs[1] });
                }
                else
                {
                    if (!companies[cmdArgs[0]].Contains(cmdArgs[1]))
                    {
                    companies[cmdArgs[0]].Add(cmdArgs[1]);
                    }
                }
            }

            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
