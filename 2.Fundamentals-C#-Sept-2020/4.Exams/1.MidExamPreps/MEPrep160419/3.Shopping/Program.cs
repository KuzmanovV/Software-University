using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Include":
                        shops.Add(cmdArgs[1]);
                        break;
                    case "Visit":
                        int numberOfShops = int.Parse(cmdArgs[2]);

                        if (numberOfShops>0 && numberOfShops<=shops.Count)
                        {
                            if (cmdArgs[1] == "first")
                            {
                                shops.RemoveRange(0, numberOfShops);
                            }
                            else
                            {
                                shops.RemoveRange(shops.Count - numberOfShops, numberOfShops);
                            }
                        }
                        break;
                    case "Prefer":
                        int index1 = int.Parse(cmdArgs[1]);
                        int index2 = int.Parse(cmdArgs[2]);
                        
                        if (index1>=0 && index2>=0 && index1<shops.Count && index2<shops.Count)
                        {
                            string container = shops[index1];
                            shops[index1] = shops[index2];
                            shops[index2] = container;
                        }
                        break;
                    case "Place":
                        int index = int.Parse(cmdArgs[2])+1;
                        
                        if (index>=0 && index<shops.Count)
                        {
                            shops.Insert(index, cmdArgs[1]);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Shops left:\n{string.Join(' ', shops)}");
        }
    }
}
