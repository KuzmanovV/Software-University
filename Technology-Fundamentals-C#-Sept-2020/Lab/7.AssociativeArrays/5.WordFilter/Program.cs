using System;
using System.Linq;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
