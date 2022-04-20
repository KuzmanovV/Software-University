using System;
using System.Collections.Generic;
using System.IO;

namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "-,.!?";

            using StreamReader reader = new StreamReader("TextFile1.txt");
            int lineCounter = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineCounter++ % 2 == 0)
                {
                    foreach (var item in chars)
                    {
                        line = line.Replace(item, '@');
                    }

                    string[] splittedLine = line.Split();
                    Array.Reverse(splittedLine);
                    Console.WriteLine(string.Join(" ", splittedLine));
                }
            }
        }
    }
}
