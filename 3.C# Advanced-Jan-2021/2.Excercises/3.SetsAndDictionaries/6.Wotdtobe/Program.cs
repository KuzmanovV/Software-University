using System;
using System.Collections.Generic;

namespace _6.Wotdtobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wordrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string colore = input[0];
                string[] dresses = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wordrobe.ContainsKey(colore))
                {
                    wordrobe[colore] = new Dictionary<string, int>();

                    for (int j = 0; j < dresses.Length; j++)
                    {
                        if (!wordrobe[colore].ContainsKey(dresses[j]))
                        {
                            wordrobe[colore][dresses[j]] = 0;
                        }

                        wordrobe[colore][dresses[j]]++;
                    }
                }
                else
                {
                    for (int j = 0; j < dresses.Length; j++)
                    {
                        if (!wordrobe[colore].ContainsKey(dresses[j]))
                        {
                            wordrobe[colore][dresses[j]] = 0;
                        }

                        wordrobe[colore][dresses[j]]++;
                    }
                }
            }

            string[] searched = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string surchedColore = searched[0];
            string surchedItem = searched[1];

            foreach (var colore in wordrobe)
            {
                Console.WriteLine($"{colore.Key} clothes:");

                foreach (var dress in colore.Value)
                {
                    Console.Write($"* {dress.Key} - {dress.Value}");

                    if (surchedColore == colore.Key && surchedItem == dress.Key)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
