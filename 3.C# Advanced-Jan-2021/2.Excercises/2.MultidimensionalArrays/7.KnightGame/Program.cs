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

                int maxAttackCounter = 0;
                int deletedKnightsCounter = 0;
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
                    
                    int maxKnightRow = -1;
                    int maxKnightCol = -1;

                    foreach (int[] knight in knights)
                    {
                        int knightRow = knight[0];
                        int knightCol = knight[1];
                        int attackCounter = 0;

                        attackCounter = CountingAttacks(knightRow - 2, knightCol - 1, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow - 2, knightCol + 1, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow - 1, knightCol - 2, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow - 1, knightCol + 2, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow + 1, knightCol - 2, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow + 1, knightCol + 2, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow + 2, knightCol - 1, board, attackCounter);
                        attackCounter = CountingAttacks(knightRow + 2, knightCol + 1, board, attackCounter);

                        if (attackCounter > maxAttackCounter)
                        {
                            maxAttackCounter = attackCounter;
                            maxKnightRow = knightRow;
                            maxKnightCol = knightCol;
                        }
                    }

                    if (maxAttackCounter != 0)
                    {
                        board[maxKnightRow, maxKnightCol] = "O";
                        deletedKnightsCounter++;
                    }

                } while (maxAttackCounter == 0);

                Console.WriteLine(deletedKnightsCounter);
            }
        }

        private static int CountingAttacks(int row, int col, string[,] board, int attackCounter)
        {
            if (row >= 0 && col >= 0 && row < board.GetLongLength(0) && col < board.GetLongLength(1) && board[row, col] == "K")
            {
                return attackCounter++;
            }
            else
            {
                return attackCounter;
            }
        }
    }
}
