using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int winCount = 0;
            int looseCount = 0;
            int drawCount = 0;

            for (int i = 1; i < 4; i++)
            {
                string first = Console.ReadLine();
                int firstOur = int.Parse(first[0].ToString());
                int firstST = int.Parse(first[2].ToString());

                if (firstOur > firstST)
                {
                    winCount++;
                }
                else if (firstOur < firstST)
                {
                    looseCount++;
                }
                else
                {
                    drawCount++;
                }
            }

            Console.WriteLine($"Team won {winCount} games.");
            Console.WriteLine($"Team lost {looseCount} games.");
            Console.WriteLine($"Drawn games: {drawCount}");
            
        }
    }
}
