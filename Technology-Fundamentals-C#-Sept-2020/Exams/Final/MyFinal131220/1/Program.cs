using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Translate":
                        string ch = cmd[1];
                        string replacement = cmd[2];
                        input = input.Replace(ch, replacement);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        string forCheck = cmd[1];
                        Console.WriteLine(input.Contains(forCheck));
                        break;
                        case "Start":
                        forCheck = cmd[1];
                        Console.WriteLine(input.IndexOf(forCheck)==0);
                        break;
                    case "Lowercase":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        char cha = char.Parse(cmd[1]);
                        int index = -1;

                        for (int i = 0; i < input.Length; i++)
                        {
                            if (cha == input[i])
                            {
                                index = i;
                            }
                        }

                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(cmd[1]);
                        int count = int.Parse(cmd[2]);
                        input = input.Remove(startIndex,count);
                        Console.WriteLine(input);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
