using System;
using System.Linq;

namespace _3.PrimariDiagonal
{
    class Program
    {
        static public int[,] MatrixInp(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = MatrixInp(size);

            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
