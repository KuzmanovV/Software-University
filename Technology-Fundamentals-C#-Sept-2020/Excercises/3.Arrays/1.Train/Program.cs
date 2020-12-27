using System;
using System.Linq;

namespace _1.NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passangers = new int[n];

            for (int i = 0; i < n; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', passangers));
            Console.WriteLine(passangers.Sum());
        }
    }
}
