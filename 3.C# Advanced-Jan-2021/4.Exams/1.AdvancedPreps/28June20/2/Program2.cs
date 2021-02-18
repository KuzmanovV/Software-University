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
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            char[,] matrix = new char[rows, cols];
            int snakeRow = -1;
            int snakeCol = -1;
            int rowB1 = -1;
            int colB1 = -1;
            int rowB2 = -1;
            int colB2 = -1;
            int food = 0;

            //Input
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    //Find the start position.
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    //Find the burrows positions.
                    if (matrix[row, col] == 'B')
                    {
                        if (rowB1 == -1)
                        {
                            rowB1 = row;
                            colB1 = col;
                        }
                        else
                        {
                            rowB2 = row;
                            colB2 = col;
                        }
                    }
                }
            }

            //Main
            while (true)
            {
                matrix[snakeRow, snakeCol] = '.';

                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        snakeRow = MoveRow(snakeRow, "up");
                        snakeCol = MoveCol(snakeCol, "up");
                        break;
                    case "down":
                        snakeRow = MoveRow(snakeRow, "down");
                        snakeCol = MoveCol(snakeCol, "down");
                        break;
                    case "left":
                        snakeRow = MoveRow(snakeRow, "left");
                        snakeCol = MoveCol(snakeCol, "left");
                        break;
                    case "right":
                        snakeRow = MoveRow(snakeRow, "right");
                        snakeCol = MoveCol(snakeCol, "right");
                        break;
                    default:
                        break;
                }

                if (!IsPositionValid(snakeRow, snakeCol, rows, cols))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food++;
                    if (food == 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        matrix[snakeRow, snakeCol] = 'S';
                        break;
                    }
                }
                else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';

                        if (snakeRow == rowB1 && snakeCol == colB1)
                        {
                            snakeRow = rowB2;
                            snakeCol = colB2;
                        }
                        else
                        {
                            snakeRow = rowB1;
                            snakeCol = colB1;
                        }
                    }

                matrix[snakeRow, snakeCol] = 'S';
            }

            Console.WriteLine($"Food eaten: {food}");

            //Output
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
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
