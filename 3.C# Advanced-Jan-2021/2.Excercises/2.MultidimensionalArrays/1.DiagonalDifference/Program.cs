using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sumPrim = 0;
            int sumSec = 0;

            for (int i = 0; i < N; i++)
            {
                sumPrim += matrix[i, i];
            }

            for (int i = 0; i < N; i++)
            {
                sumSec += matrix[i, N - i-1];
            }

            Console.WriteLine(Math.Abs(sumSec-sumPrim));
        }
    }
}
