using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "No Money")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "OutOfStock":

                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts.Contains(cmdArgs[1]))
                            {
                                gifts[gifts.FindIndex(x => x == cmdArgs[1])] = "None";
                            }
                        }
                        break;
                    case "Required":
                        if (int.Parse(cmdArgs[2]) >= 0 && int.Parse(cmdArgs[2]) < gifts.Count)
                        {
                            gifts[int.Parse(cmdArgs[2])] = cmdArgs[1];
                        }
                        break;
                    case "JustInCase":
                        gifts[gifts.Count - 1] = cmdArgs[1];
                        break;
                    default:
                        break;
                }
            }

            gifts.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(' ', gifts));
        }
    }
}
