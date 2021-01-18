using System;
using System.Linq;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] bombs = Console.ReadLine().Split();

            for (int bomb = 0; bomb < bombs.Length; bomb++)
            {
                int[] targetCoordinates = bombs[bomb].Split(",").Select(int.Parse).ToArray();
                int bombRow = targetCoordinates[0];
                int bombCol = targetCoordinates[1];
                int bombValue = matrix[bombRow, bombCol];

                if (bombValue > 0)
                {
                    if (bombRow >= 1 && bombCol >= 1)
                    {
                        if (matrix[bombRow - 1, bombCol - 1] > 0)
                        {
                            matrix[bombRow - 1, bombCol - 1] -= bombValue;
                        }
                    }

                    if (bombRow > 0)
                    {
                        if (matrix[bombRow - 1, bombCol]>0)
                        {
                        matrix[bombRow - 1, bombCol] -= bombValue;
                        }
                    }

                    if (bombRow > 0 && bombCol < size-1)
                    {
                        if (matrix[bombRow - 1, bombCol + 1]>0)
                        {
                        matrix[bombRow - 1, bombCol + 1] -= bombValue;
                        }
                    }

                    if (bombCol > 0)
                    {
                        if (matrix[bombRow, bombCol - 1]>0)
                        {
                        matrix[bombRow, bombCol - 1] -= bombValue;
                        }
                    }

                    if (bombCol < size-1)
                    {
                        if (matrix[bombRow, bombCol + 1]>0)
                        {
                        matrix[bombRow, bombCol + 1] -= bombValue;
                        }
                    }

                    if (bombRow < size-1 && bombCol > 0)
                    {
                        if (matrix[bombRow + 1, bombCol - 1]>0)
                        {
                        matrix[bombRow + 1, bombCol - 1] -= bombValue;
                        }
                    }

                    if (bombRow < size-1)
                    {
                        if (matrix[bombRow + 1, bombCol]>0)
                        {
                        matrix[bombRow + 1, bombCol] -= bombValue;
                        }
                    }

                    if (bombRow < size-1 && bombCol < size-1)
                    {
                        if (matrix[bombRow + 1, bombCol + 1]>0)
                        {
                        matrix[bombRow + 1, bombCol + 1] -= bombValue;
                        }
                    }

                    matrix[bombRow, bombCol] = 0;
                }
            }

            int active = 0;
            int sum = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    active++;
                    sum += item;
                }
            }

            Console.WriteLine($"Alive cells: {active}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
