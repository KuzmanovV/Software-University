using System;
using System.Linq;

namespace _6.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int sumBefore = 0;
            int sumAfter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumBefore += arr[j];
                }

                for (int k = arr.Length - 1; k > i; k--)
                {
                    sumAfter += arr[k];
                }

                if (sumAfter == sumBefore)
                {
                    Console.WriteLine(i);
                    System.Environment.Exit(1);
                }
                else
                {
                    sumBefore = 0;
                    sumAfter = 0;
                }

            }
            Console.WriteLine("no");
        }
    }

}

