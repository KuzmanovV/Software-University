using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _2.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            string[,] matrix = new string[rows, cols];

            string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

            //Input
            int shipsL = 0;
            int shipsR = 0;
            int total = shipsL + shipsR;
            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == "<")
                    {
                        shipsL++;
                    }
                    else if (matrix[row, col] == ">")
                    {
                        shipsR++;
                    }
                }
            }

            //Main
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string cmd = input[i];
                    int row = cmd[0];
                    int col = cmd[1];

                    if (IsPositionValid(row, col, rows, cols))
                    {
                    string hit = matrix[row, col];
                        if (hit == "<")
                        {
                            shipsL--;
                            matrix[row, col] = "X";
                        }
                        else if (hit == ">")
                        {
                            shipsR--;
                            matrix[row, col] = "X";
                        }
                        else if (hit == "#")
                        {
                            //moove left
                            col--;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                matrix[row, col] = "X";
                                }
                            }

                            //moove lu
                            row--;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove r
                            col++;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove r
                            col++;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove d
                            row++;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove d
                            row++;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove l
                            col--;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }

                            //moove l
                            col--;
                            if (IsPositionValid(row, col, rows, cols))
                            {
                                hit = matrix[row, col];
                                if (hit == "<")
                                {
                                    shipsL--;
                                    matrix[row, col] = "X";
                                }
                                else if (hit == ">")
                                {
                                    shipsR--;
                                    matrix[row, col] = "X";
                                }
                                else
                                {
                                    matrix[row, col] = "X";
                                }
                            }
                        }

                        if (shipsR<=0 || shipsL<=0)
                        {
                            break;
                        }
                    }
                }
            }
                    //Output
                    if (shipsL<=0 && shipsR>0)
                    {
                        Console.WriteLine($"Player Two has won the game! {total-shipsR} ships have been sunk in the battle.");
                    }
                    else if (shipsR<=0 && shipsL>0)
                    {
                        Console.WriteLine($"Player One has won the game! {total - shipsL} ships have been sunk in the battle.");
                    }
                    else
                    {
                        Console.WriteLine($"It's a draw! Player One has {shipsL} ships left. Player Two has {shipsR} ships left.");
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
