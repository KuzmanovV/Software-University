using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                            .Split('&', StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Add Book":
                        if (!shelf.Contains(cmdArgs[1]))
                        {
                            shelf.Insert(0, cmdArgs[1]);
                        }
                        break;
                    case "Take Book":
                        if (shelf.Contains(cmdArgs[1]))
                        {
                            shelf.Remove(cmdArgs[1]);
                        }
                        break;
                    case "Swap Books":
                        if (shelf.Contains(cmdArgs[1]) && shelf.Contains(cmdArgs[2]))
                        {
                            int indexFirst = shelf.FindIndex(x => x == cmdArgs[1]);
                            int indexSecond = shelf.FindIndex(x => x == cmdArgs[2]);
                            string container = shelf[indexFirst];
                            shelf[indexFirst] = shelf[indexSecond];
                            shelf[indexSecond] = container;
                        }
                        break;
                    case "Insert Book":
                        shelf.Add(cmdArgs[1]);
                        break;
                    case "Check Book":
                        if (int.Parse(cmdArgs[1]) > 0 && int.Parse(cmdArgs[1]) < shelf.Count)
                        {
                            Console.WriteLine(shelf[int.Parse(cmdArgs[1])]);
                        }
                        break;
                    default:
                        break;
                }
            }
            
            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
