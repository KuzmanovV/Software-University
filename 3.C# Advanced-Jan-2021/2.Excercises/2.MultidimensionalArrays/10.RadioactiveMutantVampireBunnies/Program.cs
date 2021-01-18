using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] lair = new string[rows, cols];

            int currentRow = 0;
            int currentCol = 0;
            Queue<int> bunnyRows = new Queue<int>();
            Queue<int> bunnyCols = new Queue<int>();

            //input & P localization
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = input[col].ToString();

                    if (input[col] == 'P')
                    {
                        currentCol = col;
                        currentRow = row;
                    }
                    else if (input[col] == 'B')
                    {
                        bunnyCols.Enqueue(col);
                        bunnyRows.Enqueue(row);
                    }
                }
            }

            bool won = false;
            bool dead = false;

            string cmd = Console.ReadLine();
            for (int i = 0; i < cmd.Length; i++)
            {
                //P moving
                switch (cmd[i])
                {
                    case 'U':
                        currentRow -= 1;
                        break;
                    case 'D':
                        currentRow += 1;
                        break;
                    case 'R':
                        currentCol += 1;
                        break;
                    case 'L':
                        currentCol -= 1;
                        break;
                }

                int currentBunnyRow = 0;
                int currentBunnyCol = 0;
                //win
                if (currentRow < 0 || currentRow > rows - 1 || currentCol < 0 || currentCol > cols - 1)
                {
                    won = true;

                    if (currentRow < 0)
                    {
                        currentRow += 1;
                    }

                    if (currentRow > rows - 1)
                    {
                        currentRow -= 1;
                    }

                    if (currentCol < 0)
                    {
                        currentBunnyCol += 1;
                    }

                    if (currentBunnyCol > cols - 1)
                    {
                        currentBunnyCol -= 1;
                    }
                }
                else
                {
                    //die
                    if (lair[currentRow, currentCol] == "B")
                    {
                        dead = true;
                    }
                }

                //Bunny spreading
                int forCounter = bunnyCols.Count;
                for (int j = 0; j < forCounter; j++)
                {
                    currentBunnyRow = bunnyRows.Dequeue();
                    currentBunnyCol = bunnyCols.Dequeue();
                    bunnyRows.Enqueue(currentBunnyRow);
                    bunnyCols.Enqueue(currentBunnyCol);

                    if (currentBunnyRow > 0 && currentBunnyCol > 0)
                    {
                        if (lair[currentBunnyRow - 1, currentBunnyCol - 1] != "B")
                        {
                            lair[currentBunnyRow - 1, currentBunnyCol - 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol - 1);
                        }
                    }

                    if (currentBunnyRow > 0)
                    {
                        if (lair[currentBunnyRow - 1, currentBunnyCol] != "B")
                        {
                            lair[currentBunnyRow - 1, currentBunnyCol] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol);
                        }
                    }

                    if (currentBunnyRow > 0 && currentBunnyCol < cols - 1)
                    {
                        if (lair[currentBunnyRow - 1, currentBunnyCol + 1] != "B")
                        {
                            lair[currentBunnyRow - 1, currentBunnyCol + 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol + 1);
                        }
                    }

                    if (currentBunnyCol > 0)
                    {
                        if (lair[currentBunnyRow, currentBunnyCol - 1] != "B")
                        {
                            lair[currentBunnyRow, currentBunnyCol - 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol + 1);
                        }
                    }

                    if (currentBunnyCol < cols - 1)
                    {
                        if (lair[currentBunnyRow, currentBunnyCol + 1] != "B")
                        {
                            lair[currentBunnyRow, currentBunnyCol + 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol + 1);
                        }
                    }

                    if (currentBunnyRow < rows-1 && currentBunnyCol > 0)
                    {
                        if (lair[currentBunnyRow + 1, currentBunnyCol - 1] != "B")
                        {
                            lair[currentBunnyRow + 1, currentBunnyCol - 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow + 1);
                            bunnyCols.Enqueue(currentBunnyCol - 1);
                        }
                    }

                    if (currentBunnyRow > 0)
                    {
                        if (lair[currentBunnyRow + 1, currentBunnyCol] != "B")
                        {
                            lair[currentBunnyRow + 1, currentBunnyCol] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol + 1);
                        }
                    }

                    if (currentBunnyRow > 0 && currentBunnyCol < cols - 1)
                    {
                        if (lair[currentBunnyRow + 1, currentBunnyCol + 1] != "B")
                        {
                            lair[currentBunnyRow + 1, currentBunnyCol + 1] = "B";
                            bunnyRows.Enqueue(currentBunnyRow - 1);
                            bunnyCols.Enqueue(currentBunnyCol + 1);
                        }
                    }
                }

                //final
                if (won == true || dead == true)
                {
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(lair[row, col]);
                }

                Console.WriteLine();
            }

            if (won == true)
            {
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
            else
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }
    }
}
