using System;

namespace _4.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            printTriangle(int.Parse(Console.ReadLine()));
        }

        static void printTriangle (int inp)
        {
            for (int i = 1; i <= inp; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }


            for (int i = inp - 1; i > 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
            
                Console.WriteLine();
            }
        }
    }
}
