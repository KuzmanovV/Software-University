using System;

namespace _4Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int points = 0;
            int reds = 0;
            int oranges = 0;
            int y = 0;
            int w = 0;
            int others = 0;
            int black = 0;
           

            for (int i = 1; i <= N; i++)
            {
                string colore = Console.ReadLine();

                switch (colore)
                {
                    case "red": points += 5; reds++; break;
                    case "orange": points += 10; oranges++; break;
                    case "yellow": points += 15; y++; break;
                    case "white": points += 20; w++; break;
                    case "black": points /= 2; black++; break;
                    default: others++; break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {reds}");
            Console.WriteLine($"Points from orange balls: {oranges}");
            Console.WriteLine($"Points from yellow balls: {y}");
            Console.WriteLine($"Points from white balls: {w}");
            Console.WriteLine($"Other colors picked: {others}");
            Console.WriteLine($"Divides from black balls: {black}");

        }
    }
}
