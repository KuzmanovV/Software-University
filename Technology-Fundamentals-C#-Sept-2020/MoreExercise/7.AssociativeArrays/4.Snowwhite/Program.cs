using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> output = new Dictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] cmd = command.Split(" <:> ");
                string name = cmd[0];
                string colore = cmd[1];
                int power = int.Parse(cmd[2]);

                if (!output.ContainsKey(colore))
                {
                    output[colore] = new Dictionary<string, int>();
                    output[colore][name] = power;
                }
                else
                {
                    if (output[colore].ContainsKey(name))
                    {
                        if (output[colore][name] < power)
                        {
                        output[colore][name] = power;
                        }
                    }
                    else
                    {
                        output[colore][name] = power;
                    }
                }
            }

            foreach (var item in output.OrderByDescending(x => x.Value.Values).ThenByDescending(x => x.Value.Keys.Count))
            {
                Console.WriteLine($"({item.Key}) {item.Value.Keys} <-> {item.Value.Values}");
            }

        }
    }
}
