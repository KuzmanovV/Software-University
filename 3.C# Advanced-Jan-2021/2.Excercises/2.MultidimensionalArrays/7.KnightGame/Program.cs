using System;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());


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
            
            if (size > 2)
            {
                //Finding the knights
                int removeCounter = 0;
                int maxRow = -1;
                int maxCol = -1;
                while (maxRow == -1 && maxCol == -1)
                {
                    int maxKnightsAttacks = 0;

                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            int knightsAttacks = 0;

                            if (board[row, col] == "K")
                            {
                                if (AttackIsValid(row - 2, col - 1, size) && board[row - 2, col - 1] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row - 2, col + 1, size) && board[row - 2, col + 1] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row - 1, col - 2, size) && board[row - 1, col - 2] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row - 1, col + 2, size) && board[row - 1, col + 2] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row + 1, col - 2, size) && board[row + 1, col - 2] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row + 2, col - 1, size) && board[row + 2, col - 1] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row + 2, col + 1, size) && board[row + 2, col + 1] == "K")
                                {
                                    knightsAttacks++;
                                }

                                if (AttackIsValid(row + 1, col + 2, size) && board[row + 1, col + 2] == "K")
                                {
                                    knightsAttacks++;
                                }
                            }

                            if (knightsAttacks > maxKnightsAttacks)
                            {
                                maxKnightsAttacks = knightsAttacks;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }

                    if (maxRow > -1 && maxCol > -1)
                    {
                        board[maxRow, maxCol] = "0";
                        removeCounter++;
                        maxRow = -1;
                        maxCol = -1;
                    }
                }

                //Print

                Console.WriteLine(removeCounter);

            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static bool AttackIsValid(int x, int y, int size)
        {
            if (x >= 0 && y >= 0 && x < size && y < size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
