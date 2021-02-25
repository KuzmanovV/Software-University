using System;

namespace _6.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int j = 0; j < rooms; j++)
                {
                    Console.Write($"L{floors}{j} ");
                }

            Console.WriteLine();

            for (int i = floors-1; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i%2==0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
