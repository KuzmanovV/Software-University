using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string[] coordinates = Console.ReadLine().Split();
            int rows = int.Parse(coordinates[0]);
            int cols = int.Parse(coordinates[1]);
            int[,] matrix = new int[rows, cols];

            //Input
            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] seed = input.Split().Select(int.Parse).ToArray();
                int currRow = seed[0];
                int currCol = seed[1];

                if (IsPositionValid(currRow, currCol, rows, cols))
                {
                    matrix[currRow, currCol] = -1;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            //Main
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == -1)
                    {
                        for (int newRow = row + 1; newRow < rows; newRow++)
                        {
                            matrix[newRow, col] += 1;
                        }
                        for (int newCol = col + 1; newCol < cols; newCol++)
                        {
                            matrix[row, newCol] += 1;
                        }
                        for (int newRow = row - 1; newRow >= 0; newRow--)
                        {
                            matrix[newRow, col] += 1;
                        }
                        for (int newCol = col - 1; newCol >= 0; newCol--)
                        {
                            matrix[row, newCol] += 1;
                        }

                        matrix[row, col] = 1;
                    }
                }
            }

            //Output
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
