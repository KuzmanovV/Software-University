using System;
using System.Linq;

namespace _2.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                int container = 0;

                switch (cmdArgs[0])
                {
                    case "swap":
                        container = input[int.Parse(cmdArgs[1])];
                        input[int.Parse(cmdArgs[1])] = input[int.Parse(cmdArgs[2])];
                        input[int.Parse(cmdArgs[2])] = container;
                        break;
                    case "multiply":
                        int index3 = input[int.Parse(cmdArgs[1])];
                        int index4 = input[int.Parse(cmdArgs[2])];
                        input[int.Parse(cmdArgs[1])] = index3 * index4;
                        break;
                    case "decrease":
                        for (int i = 0; i < input.Length; i++)
                        {
                            input[i]--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
