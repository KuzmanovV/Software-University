using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size <= 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                List<int[]> knights = new List<int[]>();
                string[,] board = new string[size, size];

                //Input
                for (int row = 0; row < size; row++)
                {
                    string input = Console.ReadLine();

                    for (int col = 0; col < size; col++)
                    {
                        board[row, col] = input[col].ToString();
                    }
                }

                int deleted = 0;
                int maxKnightRow = -1;
                int maxKnightCol = -1;
                int maxAttackCounter = 0;

                do
                {
                    //Collecting all knights
                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            if (board[row, col] == "K")
                            {
                                knights.Add(new int[] { row, col });
                            }
                        }
                    }
                    maxAttackCounter = 0;

                    foreach (int[] knight in knights)
                    {
                        int knightRow = knight[0];
                        int knightCol = knight[1];
                        int attackCounter = 0;

                        attackCounter += CountingAttacks(knightRow - 2, knightCol - 1, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow - 2, knightCol + 1, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow - 1, knightCol - 2, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow - 1, knightCol + 2, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow + 1, knightCol - 2, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow + 1, knightCol + 2, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow + 2, knightCol - 1, board, attackCounter);
                        attackCounter += CountingAttacks(knightRow + 2, knightCol + 1, board, attackCounter);

                        if (attackCounter > maxAttackCounter)
                        {
                            maxAttackCounter = attackCounter;
                            maxKnightRow = knightRow;
                            maxKnightCol = knightCol;
                        }
                    }

                    if (maxAttackCounter != 0)
                    {
                        board[maxKnightRow, maxKnightCol] = "0";
                        deleted++;
                        knights.Clear();
                    }

                } while (maxAttackCounter != 0);

                Console.WriteLine(deleted);
            }
        }

        private static int CountingAttacks(int r, int c, string[,] board, int attackCounter)
        {
            if (r >= 0 && c >= 0 && r < board.GetLongLength(0) && c < board.GetLongLength(1) && board[r, c] == "K")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
