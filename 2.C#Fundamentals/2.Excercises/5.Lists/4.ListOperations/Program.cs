using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> comList = command.Split().ToList();

                switch (comList[0])
                {
                    case "Add": input.Add(int.Parse(comList[1])); break;
                    case "Insert":
                        if (int.Parse(comList[2]) < input.Count && int.Parse(comList[2]) >= 0)
                        {
                            input.Insert(int.Parse(comList[2]), int.Parse(comList[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(comList[1]) < input.Count && int.Parse(comList[1]) >= 0)
                        {
                            input.RemoveAt(int.Parse(comList[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (comList[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(comList[2]); i++)
                            {
                                int container = input[0];
                                input.RemoveAt(0);
                                input.Add(container);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(comList[2]); i++)
                            {
                                int container = input[input.Count - 1];
                                input.RemoveAt(input.Count - 1);
                                input.Insert(0, container);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
