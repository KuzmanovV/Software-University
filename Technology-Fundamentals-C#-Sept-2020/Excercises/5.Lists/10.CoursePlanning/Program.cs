using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandArgs = command.Split(":");

                switch (commandArgs[0])
                {
                    case "Add":
                        if (!lessons.Contains(commandArgs[1]))
                        {
                            lessons.Add(commandArgs[1]);
                        }
                        break;
                    case "Insert":
                        if ((!lessons.Contains(commandArgs[1])
                            && (int.Parse(commandArgs[2]) >= 0)
                            && (int.Parse(commandArgs[2]) < lessons.Count)))
                        {
                            lessons.Insert(int.Parse(commandArgs[2]), commandArgs[1]);
                        }
                        break;
                    case "Remove":
                        if (lessons.Contains(commandArgs[1]))
                        {
                            lessons.Remove(commandArgs[1]);
                        }
                        if (lessons.Contains($"{commandArgs[1]}-Exercise"))
                        {
                            lessons.Remove($"{commandArgs[1]}-Exercise");
                        }
                        break;
                    case "Swap":
                        int indexS1 = lessons.IndexOf(commandArgs[1]);
                        int indexS2 = lessons.IndexOf(commandArgs[2]);

                        if (indexS1 != -1 && indexS2 != -1)
                        {
                            lessons[indexS1] = commandArgs[2];
                            lessons[indexS2] = commandArgs[1];
                        }

                        if (indexS1 + 1 < lessons.Count)
                        {
                            if (lessons[indexS1 + 1] == $"{commandArgs[2]}-Exercise")
                            {
                                lessons.Insert(indexS2 + 1, $"{commandArgs[1]}-Exercise");
                                lessons.Remove($"{commandArgs[1]}-Excersise");
                            }
                        }

                        if (indexS2 + 1 < lessons.Count)
                        {
                            if (lessons[indexS2 + 1] == $"{commandArgs[2]}-Exercise")
                            {
                                lessons.Insert(indexS1 + 1, $"{commandArgs[2]}-Exercise");
                                lessons.RemoveAt(indexS2+2);
                            }
                        }
                        break;
                    case "Exercise":
                        if (!lessons.Contains($"{commandArgs[1]}-Exercise"))
                        {
                            int index = lessons.IndexOf(commandArgs[1]);
                            if (index != -1)
                            {
                                lessons.Insert(index + 1, $"{commandArgs[1]}-Exercise");
                            }
                            else
                            {
                                lessons.Add(commandArgs[1]);
                                lessons.Add($"{commandArgs[1]}-Exercise");
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
