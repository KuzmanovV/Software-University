using System;
using System.Linq;

namespace _4.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int L = input.Length;
            int[] upperArr = new int[L / 2];
            int[] lowerArr = new int[L / 2];
            int[] outputArr = new int[L / 2];


            for (int i = 0; i < L / 4; i++)
            {
                upperArr[i] = input[L / 4 - i - 1];
            }

            for (int i = 0; i < L / 4; i++)
            {
                upperArr[i + L/4] = input[L-i-1];
            }

            for (int i = 0; i < L / 2; i++)
            {
                lowerArr[i] = input[i + L / 4];
            }

            for (int i = 0; i < L/2; i++)
            {
                outputArr[i] = lowerArr[i] + upperArr[i];
            }

            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}
