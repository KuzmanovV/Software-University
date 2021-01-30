using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine().Split().ToList();

            Func<string, int, bool> func = (name, L) => name.Length <= L;
            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, input));

            input = input.Where(name => func(name, n)).ToList();

            print(input);
        }
    }
}
