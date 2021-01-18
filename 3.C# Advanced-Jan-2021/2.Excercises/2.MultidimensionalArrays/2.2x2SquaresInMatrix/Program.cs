using System;
using System.Linq;

namespace _2._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {

                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();

                if (cols == input.Length)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = input[col];
                    }
                }
                else
                {
                    Console.WriteLine(0);
                    Environment.Exit(0);
                }
            }

            int counter = 0;

            if (rows >= 2 && cols >= 2)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    for (int col = 0; col < cols - 1; col++)
                    {
                        char comparer = matrix[row, col];
                        if (comparer == matrix[row, col + 1] && comparer == matrix[row + 1, col] && comparer == matrix[row + 1, col + 1])
                        {
                            counter++;
                        }
                    }
                }

                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
