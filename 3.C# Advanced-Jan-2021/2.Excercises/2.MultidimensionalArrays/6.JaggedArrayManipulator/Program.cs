using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                        jagged[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    
                    for (int i = 0; i < jagged[row+1].Length; i++)
                    {
                        jagged[row+1][i] /= 2;
                    }
                }
            }

            string command;

            while ((command=Console.ReadLine())!="End")
            {
                string[] cmd = Console.ReadLine().Split();

                int targetRow = int.Parse(cmd[1]);
                int targetCol = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (cmd[0]=="Add")
                {
                    jagged[targetRow][targetCol] += value;
                }
                else
                {
                    jagged[targetRow][targetCol] -= value;
                }
            }
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
