using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> func = (name, n) =>
            {
                if (name.Sum(ch => (int)ch) >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            Func<Func<string, int, bool>, List<string>, string> firstValid = (name, n) =>
            name = names.FirstOrDefault(name => func(name));
        }
    }

    
}
