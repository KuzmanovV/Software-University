using System;
using System.Collections.Generic;

namespace _3.WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, int> output = new Dictionary<string, int>();


            while ((command = Console.ReadLine()) != "stop")
            {
                int qty = int.Parse(Console.ReadLine());

                    if (output.ContainsKey(command))
                    {
                        output[command]+=qty;
                    }
                    else
                    {
                        output.Add(command, qty);
                    }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
