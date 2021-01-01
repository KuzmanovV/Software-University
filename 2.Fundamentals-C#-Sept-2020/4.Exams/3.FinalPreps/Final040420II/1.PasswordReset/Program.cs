using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string output = "";

                switch (cmd[0])
                {
                    case "TakeOdd":

                        for (int i = 1; i < input.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                output += input[i];
                            }
                        }

                        input = output;
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int index = int.Parse(cmd[1]);
                        int length = int.Parse(cmd[2]);
                        input = input.Remove(index, length);
                        Console.WriteLine(input);
                        break;
                    case "Substitute":
                        string substring = cmd[1];
                        string substitute = cmd[2];

                        if (input.Contains(substring))
                        {
                            input = input.Replace(cmd[1], cmd[2]);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
