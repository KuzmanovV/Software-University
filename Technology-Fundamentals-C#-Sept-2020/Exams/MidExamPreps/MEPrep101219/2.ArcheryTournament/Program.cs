using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            string command;
            int points = 0;

            while ((command = Console.ReadLine()) != "Game over")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else
                {
                    string[] lastCmdArgs = cmdArg[1].Split('@', StringSplitOptions.RemoveEmptyEntries);

                    int start = int.Parse(lastCmdArgs[1]);
                    int length = int.Parse(lastCmdArgs[2]);

                    if (start >= 0 && start < input.Length)
                    {
                        if (lastCmdArgs[0] == "Left")
                        {
                            while (length != 0)
                            {
                                if (start > 0)
                                {
                                    start--;
                                    length--;
                                }
                                else if (start == 0)
                                {
                                    start = input.Length - 1;
                                    length--;
                                }
                            }
                        }
                        else
                        {
                            while (length != 0)
                            {
                                if (start < input.Length - 1)
                                {
                                    start++;
                                    length--;
                                }
                                else if (start==input.Length-1)
                                {
                                    start = 0;
                                    length--;
                                }
                            }
                        }

                        if (input[start] >= 5)
                        {
                            points += 5;
                            input[start] -= 5;
                        }
                        else
                        {
                            points += input[start];
                            input[start] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" - ", input));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}



