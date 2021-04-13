using System;
using System.Linq;

namespace _2.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            int rowBee = -1;
            int colBee = -1;
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = input[col];

                    if (input[col] == 'B')
                    {
                        rowBee = row;
                        colBee = col;
                    }
                }
            }

            int flowers = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                field[rowBee, colBee] = '.';

                rowBee = MoveRow(rowBee, command);
                colBee = MoveCol(colBee, command);

                if (!IsPositionValid(rowBee, colBee, n, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (field[rowBee, colBee] == 'f')
                {
                    flowers++;
                }

                if (field[rowBee, colBee] == 'O')
                {
                    field[rowBee, colBee] = '.';

                    rowBee = MoveRow(rowBee, command);
                    colBee = MoveCol(colBee, command);

                    if (!IsPositionValid(rowBee, colBee, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (field[rowBee, colBee] == 'f')
                    {
                        flowers++;
                    }
                }

                field[rowBee, colBee] = 'B';
            }

            if (flowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);
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
