using System;

namespace _2.ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int currRow = -1;
            int currCol = -1;
            int oldRow = -1;
            int oldCol = -1;
            int oldTrapRow = -1;
            int oldTrapCol = -1;

            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }


            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                matrix[currRow, currCol] = '-';
                oldTrapRow = currRow;
                oldTrapCol = currCol;
                currRow = MoveRow(currRow, command);
                currCol = MoveCol(currCol, command);

                if (!IsPositionValid(currRow, currCol, size, size))
                {
                    if (currRow == size)
                    {
                        currRow = 0;
                    }
                    else if (currRow == -1)
                    {
                        currRow = size - 1;
                    }

                    if (currCol == size)
                    {
                        currCol = 0;
                    }
                    else if (currCol == -1)
                    {
                        currCol = size - 1;
                    }
                }

                if (matrix[currRow, currCol] == 'B')
                {
                    oldRow = currRow;
                    oldCol = currCol;
                    currRow = MoveRow(currRow, command);
                    currCol = MoveCol(currCol, command);
                    if (!IsPositionValid(currRow, currCol, size, size))
                    {
                        if (currRow == size)
                        {
                            currRow = 0;
                        }
                        else if (currRow == -1)
                        {
                            currRow = size - 1;
                        }

                        if (currCol == size)
                        {
                            currCol = 0;
                        }
                        else if (currCol == -1)
                        {
                            currCol = size - 1;
                        }
                    }
                    matrix[currRow, currCol] = 'f';
                    matrix[oldRow, oldCol] = 'B';
                }
                else if (matrix[currRow, currCol] == 'T')
                {
                    currRow = oldTrapRow;
                    currCol = oldTrapCol;
                    matrix[currRow, currCol] = 'f';
                }
                else if (matrix[currRow, currCol] == 'F')
                {
                    matrix[currRow, currCol] = 'f';
                    break;
                }

            }

            if (matrix[currRow, currCol] == 'f')
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
                matrix[currRow, currCol] = 'f';
            }

            Print(matrix);
        }

        public static void Print(char[,] matrix)
        {
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
