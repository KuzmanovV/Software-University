using System;
using System.Collections.Generic;

namespace _3.WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (output.ContainsKey(word))
                {
                    output[word].Add(synonym);
                }
                else
                {
                    output.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
