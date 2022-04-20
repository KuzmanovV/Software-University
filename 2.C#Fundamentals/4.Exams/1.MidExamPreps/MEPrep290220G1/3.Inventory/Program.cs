using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Collect":
                        if (!journal.Contains(cmdArgs[1]))
                        {
                            journal.Add(cmdArgs[1]);
                        }
                        break;
                    case "Drop":
                        if (journal.Contains(cmdArgs[1]))
                        {
                            journal.Remove(cmdArgs[1]);
                        }
                        break;
                    case "Combine Items":
                        string[] combineCommand = cmdArgs[1].Split(":", StringSplitOptions.RemoveEmptyEntries);

                        if (journal.Contains(combineCommand[0]))
                        {
                            journal.Insert(journal.FindIndex(x => x==combineCommand[0])+1, combineCommand[1]);
                        }
                        break;
                    case "Renew":
                        if (journal.Contains(cmdArgs[1]))
                        {
                            journal.Add(cmdArgs[1]);
                            journal.Remove(cmdArgs[1]);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
