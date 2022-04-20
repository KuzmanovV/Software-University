using System;
using System.Numerics;

namespace _2.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger B = 1;

            for (int i = 2; i <= N; i++)
            {
                B *= i;
            }

            Console.WriteLine(B);
        }
    }
}
