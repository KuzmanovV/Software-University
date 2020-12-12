using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, List<double>> order = new Dictionary<string, List<double>>();

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command.Split();
                double price = double.Parse(cmdArgs[1]);
                int qty = int.Parse(cmdArgs[2]);

                if (!order.ContainsKey(cmdArgs[0]))
                {
                    order.Add(cmdArgs[0], new List<double> { price, qty});
                }
                else
                {
                    order[cmdArgs[0]][0] = price;
                    order[cmdArgs[0]][1] +=qty;
                }
            }

            foreach (var item in order)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}
