using System;

namespace _4.Tibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > 3)
            {
            PrintTribonacci(num);
            }
            else if (num == 2)
            {
                Console.WriteLine("1, 1");
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private static void PrintTribonacci(int num)
        {
            int[] trib = new int[num+1];
            trib[0] = 0;
            trib[1] = trib[2] = 1;
            trib[3] = 2;

            for (int i = 1; i < 4; i++)
            {
                Console.Write($"{trib[i]} ");
            }
            for (int i = 4; i <= num; i++)
            {
                trib[i] = trib[i - 1] + trib[i - 2] + trib[i - 3];
                Console.Write($"{trib[i]} ");
            }
        }
    }
}
