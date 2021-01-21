using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<string> n = new HashSet<string>();
            HashSet<string> m = new HashSet<string>();

            for (int i = 0; i < input[0]; i++)
            {
                n.Add(Console.ReadLine());
            }
            
            for (int i = 0; i < input[1]; i++)
            {
                m.Add(Console.ReadLine());
            }

                n.IntersectWith(m);
            
            foreach (var item in n)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
