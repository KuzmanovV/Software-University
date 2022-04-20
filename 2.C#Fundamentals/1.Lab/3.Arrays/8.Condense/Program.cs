using System;
using System.Linq;

namespace _8.Condense
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            while (input.Length != 1)
            {

                int[] newArr = new int[input.Length - 1];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    newArr[i] = input[i] + input[i + 1];
                }

                input = newArr;
            }

            Console.WriteLine(input[0]);
        }
    }
}
