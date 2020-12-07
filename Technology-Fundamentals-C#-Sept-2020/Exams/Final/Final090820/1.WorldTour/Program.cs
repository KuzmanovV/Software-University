using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine())!= "Travel")
            {
                string[] cmd = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Add Stop":
                        int index = int.Parse(cmd[1]);
                        string additionalStop = cmd[2];

                        if (index>-1 && index<input.Length)
                        {
                            input = input.Insert(index, additionalStop);
                        }
                       
                        Console.WriteLine(input);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);

                        if (startIndex<=endIndex&&startIndex>-1&&startIndex<input.Length
                            &&endIndex>-1&&endIndex<input.Length)
                        {
                            input = input.Remove(startIndex, endIndex-startIndex+1);
                        }

                        Console.WriteLine(input);
                        break;
                    case "Switch":
                        input = input.Replace(cmd[1], cmd[2]);
                        Console.WriteLine(input);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
