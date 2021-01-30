using System;

namespace _1.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            print(input);
        }
    }
}
