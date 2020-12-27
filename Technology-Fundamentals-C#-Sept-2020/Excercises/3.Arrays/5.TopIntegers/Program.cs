using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            bool isBigger = true;
            int top = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    top = arr[i];
                    
                    if (arr[i] <= arr[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write($"{arr[i]} ");
                }

                isBigger = true;
            }

            Console.WriteLine(arr[arr.Length-1]);
        }
    }
}
