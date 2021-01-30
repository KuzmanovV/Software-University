using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            input.Reverse();

            Func<int, bool> notPredicate = x => x % n != 0;
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            print(input.Where(notPredicate).ToList());
        }
    }
}
