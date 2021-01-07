using System;
using System.Linq;


namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static public int[,] MatrixInput(int[] sizes)
        {
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

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

            int[,] matrix = MatrixInput(sizes);

            int sum = 0;
            int maxSum = 0;

            int[,] targetMatrix = new int[2, 2];
            
            for (int i = 0; i < sizes[0]-1; i++)
            {
                for (int j = 0; j < sizes[1]-1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        targetMatrix[0, 0] = matrix[i, j];
                        targetMatrix[0, 1] = matrix[i, j+1];
                        targetMatrix[1, 0] = matrix[i+1, j];
                        targetMatrix[1, 1] = matrix[i+1, j+1];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{targetMatrix[i,j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
