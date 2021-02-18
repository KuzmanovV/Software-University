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
            int commands = int.Parse(Console.ReadLine());

            int currRow = -1;
            int currCol = -1;

            //Input
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    //Find the start position.
                    if (matrix[row, col] == 'f')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            //Main
            bool finished = false;
            int firstRow = -1;
            int firstCol = -1;
            for (int i = 0; i < commands; i++)
            {
                matrix[currRow, currCol] = '-';
                firstRow = currRow;
                firstCol = currCol;

                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        currRow = MoveRow(currRow, "up");
                        currCol = MoveCol(currCol, "up");
                        break;
                    case "down":
                        currRow = MoveRow(currRow, "down");
                        currCol = MoveCol(currCol, "down");
                        break;
                    case "left":
                        currRow = MoveRow(currRow, "left");
                        currCol = MoveCol(currCol, "left");
                        break;
                    case "right":
                        currRow = MoveRow(currRow, "right");
                        currCol = MoveCol(currCol, "right");
                        break;
                    default:
                        break;
                }

                //Check for validation field
                if (IsPositionValid(currRow, currCol, rows, cols))
                {
                    //Win
                    if (matrix[currRow, currCol] == 'F')
                    {
                        matrix[currRow, currCol] = 'f';
                        finished = true;
                        break;
                    }
                    else if (matrix[currRow, currCol] == 'B')
                    {
                        switch (command)
                        {
                            case "up":
                                currRow = MoveRow(currRow, "up");
                                currCol = MoveCol(currCol, "up");
                                break;
                            case "down":
                                currRow = MoveRow(currRow, "down");
                                currCol = MoveCol(currCol, "down");
                                break;
                            case "left":
                                currRow = MoveRow(currRow, "left");
                                currCol = MoveCol(currCol, "left");
                                break;
                            case "right":
                                currRow = MoveRow(currRow, "right");
                                currCol = MoveCol(currCol, "right");
                                break;
                            default:
                                break;
                        }
                        //Go around
                        if (currRow == rows)
                        {
                            currRow = 0;
                        }
                        else if (currRow < 0)
                        {
                            currRow = rows - 1;
                        }

                        if (currCol == cols)
                        {
                            currCol = 0;
                        }
                        else if (currCol < 0)
                        {
                            currCol = cols - 1;
                        }
                    }
                    else if (matrix[currRow, currCol] == 'T')
                    {
                        currRow = firstRow;
                        currCol = firstCol;
                    }
                }
                //Go around
                else
                {
                    if (currRow == rows)
                    {
                        currRow = 0;
                    }
                    else if (currRow < 0)
                    {
                        currRow = rows - 1;
                    }

                    if (currCol == cols)
                    {
                        currCol = 0;
                    }
                    else if (currCol < 0)
                    {
                        currCol = cols - 1;
                    }
                }

                if (matrix[currRow, currCol] != 'F')
                {
                    matrix[currRow, currCol] = 'f';
                }
                else
                {
                    matrix[currRow, currCol] = 'f';
                    finished = true;
                    break;
                }
            }

            //Output
            if (finished)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

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