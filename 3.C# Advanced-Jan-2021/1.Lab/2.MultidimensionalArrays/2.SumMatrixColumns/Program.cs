using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static public int[,] MatrixInp(int[] sizes)
        {
            int[,] matrix = new int[sizes[0], sizes[1]];
            
            for (int i = 0; i < sizes[0]; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = MatrixInp(sizes);

            for (int i = 0; i < sizes[1]; i++)
            {
                int sum = 0;

                for (int j = 0; j < sizes[0]; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
