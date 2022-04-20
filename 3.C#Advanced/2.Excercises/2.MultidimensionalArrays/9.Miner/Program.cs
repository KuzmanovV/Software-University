using System;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] cmd = Console.ReadLine().Split();

            string[,] field = new string[size, size];

            int currentRow = 0;
            int currentCol = 0;
            int allCoals = 0;

            for (int row = 0; row < size; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = input[col];

                    if (field[row, col] == "s")
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (field[row, col] == "c")
                    {
                        allCoals++;
                    }
                }
            }

            int coalCollected = 0;
            bool gameOver = false;

            for (int i = 0; i < cmd.Length; i++)
            {
                switch (cmd[i])
                {
                    case "left":
                        if (currentCol > 0)
                        {
                            currentCol -= 1;
                        }
                        break;
                    case "right":
                        if (currentCol <size-1)
                        {
                            currentCol += 1;
                        }
                        break;
                    case "up":
                        if (currentRow >0)
                        {
                            currentRow -= 1;
                        }
                        break;
                    case "down":
                        if (currentRow <size-1)
                        {
                            currentRow += 1;
                        }
                        break;
                    default:
                        break;
                }

                if (field[currentRow, currentCol] == "c")
                {
                    field[currentRow, currentCol] = "*";
                    coalCollected++;

                    if (coalCollected == allCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        gameOver = true;
                        break;
                    }
                }
                else if (field[currentRow, currentCol] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    gameOver = true;
                    break;
                }
            }

            if (!gameOver)
            {
                Console.WriteLine($"{allCoals - coalCollected} coals left. ({currentRow}, {currentCol})");
            }
        }
    }
}
