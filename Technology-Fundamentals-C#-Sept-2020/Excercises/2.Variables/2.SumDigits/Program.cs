using System;

namespace _2.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int single = int.Parse(Console.ReadLine());
            int sum = 0;

            while (single > 0)
            {
                sum += single % 10;
                single /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
