using System;
using System.Linq;

namespace _2.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int M = input[0];
            int N = input[1];

            int[,] matrix = new int[N, M];

            int curRow = -1;
            int curCol = -1;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = 0;

                    if (matrix[row, col] == 'S')
                    {
                        curRow = row;
                        curCol = col;
                    }
                }
            }

            string position;
            while ((position = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] cmd = position.Split(" ").Select(int.Parse).ToArray();

                try
                {
                    curRow = cmd[0];
                    curCol = cmd[1];
                    matrix[curRow, curCol] = 1;

                    int initRow = curRow;
                    int initCol = curCol;
                    //down
                    for (int i = curRow + 1; i < N; i++)
                    {
                        curRow++;
                        matrix[curRow, curCol]++;
                    }
                    //Print(matrix);
                    //Console.WriteLine();

                    //right
                    curRow = initRow;
                    curCol = initCol;
                    for (int i = curCol + 1; i < M; i++)
                    {
                        curCol++;
                        matrix[curRow, curCol]++;
                    }
                    //Print(matrix);
                    //Console.WriteLine();

                    //Up
                    curRow = initRow;
                    curCol = initCol;
                    for (int i = curRow - 1; i >= 0; i--)
                    {
                        curRow--;
                        matrix[curRow, curCol]++;
                    }
                    //Print(matrix);
                    //Console.WriteLine();

                    //Left
                    curRow = initRow;
                    curCol = initCol;
                    for (int i = curCol - 1; i >= 0; i--)
                    {
                        curCol--;
                        matrix[curRow, curCol]++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            Print(matrix);
        }

        //Printer
        public static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
