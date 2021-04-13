using System;

namespace _2.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int curRow = -1;
            int curCol = -1;
            int firstORow = -1;
            int firstOCol = -1;
            int secondORow = -1;
            int secondOCol = -1;
            int money = 0;
            bool isOut = false;
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        curRow = row;
                        curCol = col;
                    }

                    if (matrix[row, col] == 'O')
                    {
                        if (firstORow == -1)
                        {
                            firstORow = row;
                            firstOCol = col;
                        }
                        else
                        {
                            secondORow = row;
                            secondOCol = col;
                        }
                    }
                }
            }

            while (money < 50)
            {
                string command = Console.ReadLine();
                matrix[curRow, curCol] = '-';

                curRow = MoveRow(curRow, command);
                curCol = MoveCol(curCol, command);

                if (!IsPositionValid(curRow, curCol, size, size))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    isOut = true;
                    break;
                }

                if (matrix[curRow, curCol] == 'O')
                {
                    if (curRow == firstORow && curCol == firstOCol)
                    {
                        matrix[curRow, curCol] = '-';
                        curRow = secondORow;
                        curCol = secondOCol;
                    }
                    else
                    {
                        matrix[curRow, curCol] = '-';
                        curRow = firstORow;
                        curCol = firstOCol;
                    }
                }
                else if (matrix[curRow, curCol] != '-' && matrix[curRow, curCol]!='O')
                {
                    money += int.Parse((matrix[curRow,curCol]).ToString());
                }
            }

            if (!isOut)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
                matrix[curRow, curCol] = 'S';
            }

            Console.WriteLine($"Money: {money}");
            Print(matrix);
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

        //Moving position
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
    }
}
