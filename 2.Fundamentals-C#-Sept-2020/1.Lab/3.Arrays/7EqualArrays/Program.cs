using System;
using System.Linq;

namespace _7EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrFirst = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arrSecond = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int differenceIndex = -1;
            int sum = 0;

            for (int i = 0; i < arrFirst.Length; i++)
            {
                if (arrFirst[i] != arrSecond[i])
                {
                    differenceIndex = i;
                    
                    break;
                }
                sum += arrSecond[i];
            }

            if (differenceIndex >= 0)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differenceIndex} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
