using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount.Add(word.ToLower(), 0);
            }

            string[] lines = File.ReadAllLines("text.txt");

            foreach (var line in lines)
            {
                string[] lineWords = line.Split(new string[] { " ", ",", ".", "!", "?", "-" },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in lineWords)
                {
                    if (wordsCount.ContainsKey(word.ToLower()))
                    {
                        wordsCount[word.ToLower()]++;
                    }
                }
            }

            int counter = 0;
            foreach (var word in wordsCount.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText("../../../actualResult.txt", $"{word.Key} - {word.Value}");
                counter++;

                if (counter != wordsCount.Count)
                {
                    File.AppendAllText("../../../actualResult.txt", Environment.NewLine);
                }
            }

            string expected = File.ReadAllText("expectedResult.txt");
            string actual = File.ReadAllText("actualResult.txt");

            if (expected == actual)
            {
                Console.WriteLine("100/100!");
            }
            else
            {
                Console.WriteLine("Not as expected!");
            }
        }
    }
}
