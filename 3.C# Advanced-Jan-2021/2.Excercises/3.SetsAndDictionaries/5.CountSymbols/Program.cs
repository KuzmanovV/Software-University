using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> symbols = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols[text[i]] = 0;
                }

                symbols[text[i]]++;
            }

            foreach (var item in symbols.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
