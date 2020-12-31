using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            string command;

            while ((command = Console.ReadLine())!="END")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Change":

                        break;
                    case "Hide":
                        break;
                    case "Switch":
                        break;
                    case "Insert":
                        break;
                    case "Reverse":
                        break;
                }
            }
        }
    }
}
