using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            //Input
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            //Analyze
            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(e => e * 2).ToArray();
                    jagged[row+1] = jagged[row+1].Select(e => e * 2).ToArray();
                }
                else if (jagged[row].Length != jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(e => e / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(e => e / 2).ToArray();
                }
            }

            //Commands
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int targetRow = int.Parse(cmd[1]);
                int targetCol = int.Parse(cmd[2]);
                double value = double.Parse(cmd[3]);

                if (cmd.Length == 4 && targetRow >= 0 && targetCol >= 0 
                    && targetRow < jagged.GetLength(0) && targetCol<jagged[targetRow].Length)
                {
                    if (cmd[0] == "Add")
                    {
                        jagged[targetRow][targetCol] += value;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        jagged[targetRow][targetCol] -= value;
                    }
                }
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
