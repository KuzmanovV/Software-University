using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        /*static public char[,] MatrixInp(int size)
        {
            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }*/
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //char[,] matrix = MatrixInp(size);

            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            bool isFound = false;
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
