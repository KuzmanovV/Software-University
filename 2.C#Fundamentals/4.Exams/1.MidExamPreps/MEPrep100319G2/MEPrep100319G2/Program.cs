using System;
using System.Collections.Generic;
using System.Linq;

namespace MEPrep100319G2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Delete":
                        int givenIndex = int.Parse(cmdArgs[1]);

                        if (givenIndex >= 0 && givenIndex + 1 < input.Count)
                        {
                            input.RemoveAt(givenIndex + 1);
                        }
                        break;
                    case "Swap":
                        string word2 = cmdArgs[2];
                        if (input.Contains(cmdArgs[1]) && input.Contains(cmdArgs[2]))
                        {
                            int index1 = input.FindIndex(x => x == cmdArgs[1]);
                            int index2 = input.FindIndex(x => x == cmdArgs[2]);
                            string container = input[index1];
                            input[index1] = input[index2];
                            input[index2] = container;
                        }
                        break;
                    case "Put":
                        int index = int.Parse(cmdArgs[2]) - 1;

                        if (index >= 0 && index <= input.Count)
                        {
                            input.Insert(index, cmdArgs[1]);
                        }
                        break;
                    case "Sort":
                        input.Sort();
                        input.Reverse();
                        break;
                    case "Replace":
                        if (input.Contains(cmdArgs[2]))
                        {
                            index = input.FindIndex(x => x == cmdArgs[2]);
                            input[index] = cmdArgs[1];
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', input));
        }
    }
}
