using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            List<string> filtered = new List<string>();

            Func<List<string>, List<string>, List<string>> doublePeople = (people, filtered) =>
            {
                foreach (var item in filtered)
                {
                    people.Add(item);
                }

                return people.ToList(); ;
            };

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmd = command.Split();

                switch (cmd[1])
                {
                    case "StartsWith":
                        filtered = people.Where(p => startsWith(p, cmd[2])).ToList();
                        break;
                    case "EndsWith":
                        filtered = people.Where(p => endsWith(p, cmd[2])).ToList();
                        break;
                    case "Length":
                        filtered = people.Where(p => checkLength(p, int.Parse(cmd[2]))).ToList();
                        break;
                    default:
                        break;
                }
                switch (cmd[0])
                {
                    case "Remove":
                        people = people.Where(p => !filtered.Contains(p)).ToList();
                        break;
                    case "Double":
                        people = doublePeople(people, filtered);
                        break;
                    default:
                        break;
                }
            }

            if (people.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
