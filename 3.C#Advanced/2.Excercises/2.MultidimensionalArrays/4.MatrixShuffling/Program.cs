using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command;
            while ((command=Console.ReadLine())!="END")
            {
                string[] cmd = command.Split();

                if (cmd[0] == "swap" && cmd.Length == 5)
                {
                    int takeRow = int.Parse(cmd[1]);
                    int takeCol = int.Parse(cmd[2]);
                    int placeRow = int.Parse(cmd[3]);
                    int placeCol = int.Parse(cmd[4]);

                    string container = "";

                    if (takeRow >= 0 && takeCol >= 0 &&
                        placeRow >= 0 && placeCol >= 0 &&
                        takeRow <= rows && takeCol <= cols &&
                        placeRow <= rows && placeCol <= cols)
                    {
                        container = matrix[placeRow, placeCol];
                        matrix[placeRow, placeCol] = matrix[takeRow, takeCol];
                        matrix[takeRow, takeCol] = container;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
