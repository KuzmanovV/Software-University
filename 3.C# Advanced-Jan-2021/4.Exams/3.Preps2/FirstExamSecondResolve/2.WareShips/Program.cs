using System;
using System.Linq;
using System.Threading.Channels;

namespace _2.WareShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            string[] hits = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int row = 0; row < size; row++)
            {
                string[] currentRow = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            Print(matrix);
        }
        public static void Print(string[,] matrix)
        {
            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
