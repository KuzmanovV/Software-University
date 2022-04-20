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

            //Input
            int rowS = -1;
            int colS = -1;
            int rowO1 = -1;
            int colO1 = -1;
            int rowO2 = -1;
            int colO2 = -1;
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        rowS = row;
                        colS = col;
                    }

                    if (matrix[row, col] == 'O')
                    {
                        if (rowO1 == -1)
                        {
                            rowO1 = row;
                            colO1 = col;
                        }
                        else
                        {
                            rowO2 = row;
                            colO2 = col;
                        }
                    }

                }
            }

            //Main
            int money = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                matrix[rowS, colS] = '-';

                rowS = MoveRow(rowS, command);
                colS = MoveCol(colS, command);

                if (!IsPositionValid(rowS, colS, rows, cols))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                if (Char.IsDigit(matrix[rowS, colS]))
                {
                    money += int.Parse(matrix[rowS, colS].ToString());

                    if (money >= 50)
                    {
                        Console.WriteLine("Good news! You succeeded in collecting enough money!");
                        matrix[rowS, colS] = 'S';
                        break;
                    }
                }
                else if (matrix[rowS, colS] == 'O')
                {
                    matrix[rowS, colS] = '-';

                    if (rowS == rowO1 && colS == colO1)
                    {
                        rowS = rowO2;
                        colS = colO2;
                    }
                    else
                    {
                        rowS = rowO1;
                        colS = colO1;
                    }
                }

                matrix[rowS, colS] = 'S';
            }

            Console.WriteLine($"Money: {money}");

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
