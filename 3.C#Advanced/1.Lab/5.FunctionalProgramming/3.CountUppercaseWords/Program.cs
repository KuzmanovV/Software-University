using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = text => Char.IsUpper(text[0]);
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(filter).ToArray();

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
