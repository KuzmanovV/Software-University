using System;
using System.Linq;

namespace _2.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            int curRow = -1;
            int curCol = -1;

            bool isDead = false;
            string currentRow = Console.ReadLine();

            char[,] matrix = new char[rows, currentRow.Length];
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'M')
                    {
                        curRow = row;
                        curCol = col;
                    }
                }

                if (row < rows - 1)
                {
                    currentRow = Console.ReadLine();
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string direction = command[0];
                int bRow = int.Parse(command[1]);
                int bCol = int.Parse(command[2]);
                matrix[bRow, bCol] = 'B'; matrix[curRow, curCol] = '-';
                curRow = MoveRow(curRow, direction);
                curCol = MoveCol(curCol, direction);

                if (IsPositionValid(curRow, curCol, rows, currentRow.Length))
                {
                    if (matrix[curRow, curCol] == 'B')
                    {
                        lives -= 2;

                        if (lives <= 0)
                        {
                            matrix[curRow, curCol] = 'X';
                            isDead = true;
                            break;
                        }
                    }
                    else if (matrix[curRow, curCol] == 'P')
                    {
                        matrix[curRow, curCol] = '-';
                        lives--;
                        break;
                    }

                    matrix[curRow, curCol] = 'M';
                    lives--;
                    if (lives <= 0)
                    {
                        matrix[curRow, curCol] = 'X';
                        isDead = true;
                        break;
                    }
                }
                else
                {
                    lives--;
                    if (lives <= 0)
                    {
                        isDead = true;
                        break;
                    }
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Mario died at {curRow};{curCol}.");
            }
            else
            {
                if (lives < 0)
                {
                    lives = 0;
                }

                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }

            Print(matrix);
        }

        //Printer
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

        //Moving position
        public static int MoveRow(int row, string movement)
        {
            if (movement == "W")
            {
                return row - 1;
            }
            if (movement == "S")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "A")
            {
                return col - 1;
            }
            if (movement == "D")
            {
                return col + 1;
            }

            return col;
        }

        //Verifying position
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
