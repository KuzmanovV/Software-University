using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.KnightsOfHounor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().Select(w => $"Sir {w}").ToList();

            Action<List<string>> print = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            print(names);
        }
    }
}
