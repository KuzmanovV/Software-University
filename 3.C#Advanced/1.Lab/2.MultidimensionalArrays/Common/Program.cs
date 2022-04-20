using System;
using System.Linq;

namespace Common
{
    public class C
    {
        static public int[,] MatrixInput(int[] sizes)
        {
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
