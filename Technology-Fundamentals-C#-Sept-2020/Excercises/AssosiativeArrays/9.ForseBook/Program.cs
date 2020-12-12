using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ForseBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            output["D"] = new List<string>();
            output["L"] = new List<string>();

            string command;

            while ((command = Console.ReadLine())!= "Lumpawaroo")
            {
                string[] cmd = command.Split();

                if (cmd[1] == "|")
                {
                    if (!output[cmd[0]].Contains(cmd[2]))
                    {
                        output[cmd[0]].Add(cmd[2]);
                    }
                }
                else
                {
                    if (!output[cmd[2]].Contains(cmd[0]))
                    {
                        output.K
                        output[].Add(cmd[0]);
                    }
                }
            }
        }
    }
}
