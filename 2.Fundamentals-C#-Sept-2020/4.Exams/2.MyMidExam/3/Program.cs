using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Add":
                        if (!cars.Contains(cmdArgs[1]))
                        {
                            cars.Add(cmdArgs[1]);
                            Console.WriteLine("Card successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        break;
                    case "Remove":
                        if (!cars.Contains(cmdArgs[1]))
                        {
                            Console.WriteLine("Card not found");
                        }
                        else
                        {
                            Console.WriteLine("Card successfully sold");
                            cars.Remove(cmdArgs[1]);
                        }
                        break;
                    case "Remove At":
                        int index = int.Parse(cmdArgs[1]);
                        if (index >= 0 && index < cars.Count)
                        {
                            cars.RemoveAt(index);
                            Console.WriteLine("Card successfully sold");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        index = int.Parse(cmdArgs[1]);

                        if (index>=0 && index<cars.Count)
                        {
                            if (cars.Contains(cmdArgs[2]))
                            {
                                Console.WriteLine("Card is already bought");
                            }
                            else
                            {
                                cars.Insert(index, cmdArgs[2]);
                                Console.WriteLine("Card successfully bought");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                }
            }
            
            Console.WriteLine(string.Join(", ", cars));
        }
    }
}
