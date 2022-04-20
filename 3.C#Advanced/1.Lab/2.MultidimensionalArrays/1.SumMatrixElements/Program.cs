using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            string[,] output = new string[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                for (int j = 0; j < sizes[1]; j++)
                {
                    output[i,j] = input[j];
                }
            }

            Console.WriteLine(output.GetLength(0));
            Console.WriteLine(output.GetLength(1));

            int sum = 0;

            foreach (var item in output)
            {
                sum += int.Parse(item);
            }

            Console.WriteLine(sum);
        }
    }
}
