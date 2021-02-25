using System;

namespace _05Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double output = 0;

            for (int i = 1; i <= n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                output += m;
            }

            Console.WriteLine($"{output / n:f2}");
        }
    }
}
