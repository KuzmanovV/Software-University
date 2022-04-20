using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, int, bool> predicate = (numb, divider) => numb % divider == 0;

            for (int i = 1; i <=n; i++)
            {
                if (dividers.All(d=>predicate(i,d)))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
