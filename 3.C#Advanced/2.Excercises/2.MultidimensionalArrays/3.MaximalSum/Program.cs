using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            if (rows >= 3 && cols >= 3)
            {

                int[,] matrix = new int[rows, cols];

                for (int row = 0; row < rows; row++)
                {
                    int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = input[col];
                    }
                }

                int maxSum = int.MinValue;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < rows - 2; row++)
                {
                    for (int col = 0; col < cols - 2; col++)
                    {
                        int sum = 0;

                        sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxRow = row;
                            maxCol = col;
                        }
                    }
                }

                Console.WriteLine($"Sum = {maxSum}");

                for (int row = maxRow; row < maxRow + 3; row++)
                {
                    for (int col = maxCol; col < maxCol + 3; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
