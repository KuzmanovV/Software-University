using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            char[,] lair = new char[rows, cols];
            List<int[]> bunniesCoordinates = new List<int[]>();
            int currentPRow = -1;
            int currentPCol = -1;

            //input & P & B localization
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = input[col];

                    if (input[col] == 'P')
                    {
                        currentPCol = col;
                        currentPRow = row;
                    }
                }
            }

            bool won = false;
            bool dead = false;
            bool insideAlive = false;

            string cmd = Console.ReadLine();
            for (int i = 0; i < cmd.Length; i++)
            {
                //Collect the new bunnies coordinates
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            bunniesCoordinates.Add(new int[2] { row, col });
                        }
                    }
                }

                //P moving
                int nextPRow = currentPRow;
                int nextPCol = currentPCol;
                switch (cmd[i])
                {
                    case 'U':
                        nextPRow--;
                        break;
                    case 'D':
                        nextPRow++;
                        break;
                    case 'R':
                        nextPCol++;
                        break;
                    case 'L':
                        nextPCol--;
                        break;
                }

                //Main logic!
                if (!IsValid(nextPRow, nextPCol, lair))
                {
                    won = true;
                    lair[currentPRow, currentPCol] = '.';
                }
                else if (lair[nextPRow, nextPCol] == '.')
                {
                    lair[nextPRow, nextPCol] = 'P';
                    lair[currentPRow, currentPCol] = '.';
                    currentPRow = nextPRow;
                    currentPCol = nextPCol;
                    insideAlive = true;                }
                else if (lair[nextPRow, nextPCol] == 'B')
                {
                    dead = true;
                    lair[currentPRow, currentPCol] = '.';
                    currentPRow = nextPRow;
                    currentPCol = nextPCol;
                }

                //Bunny spreading
                foreach (var bunnyCoordinates in bunniesCoordinates)
                {
                    int currentBunnyRow = bunnyCoordinates[0];
                    int currentBunnyCol = bunnyCoordinates[1];

                    if (IsValid(currentBunnyRow - 1, currentBunnyCol, lair))
                    {
                        lair[currentBunnyRow - 1, currentBunnyCol] = 'B';
                    }

                    if (IsValid(currentBunnyRow, currentBunnyCol + 1, lair))
                    {
                        lair[currentBunnyRow, currentBunnyCol + 1] = 'B';
                    }

                    if (IsValid(currentBunnyRow + 1, currentBunnyCol, lair))
                    {
                        lair[currentBunnyRow + 1, currentBunnyCol] = 'B';
                    }

                    if (IsValid(currentBunnyRow, currentBunnyCol - 1, lair))
                    {
                        lair[currentBunnyRow, currentBunnyCol - 1] = 'B';
                    }

                }

                //Check case 2 if hit by bunny after spreading
                if (insideAlive)
                {
                    if (lair[currentPRow,currentPCol]=='B')
                    {
                        dead = true;
                        break;
                    }
                }

                if (dead || won)
                {
                    break;
                }
            }

            //Output
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(lair[row,col]);
                }

                Console.WriteLine();
            }

            string result = "";

            if (won)
            {
                result += "won: ";
            }
            else if (dead)
            {
                result += "dead: ";
            }

            Console.Write($"{result}{currentPRow} {currentPCol}");
        }

        private static bool IsValid(int row, int col, char[,] lair)
        {
            if (row >= 0 && col >= 0 && row < lair.GetLength(0) && col < lair.GetLength(1))
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