using System;

namespace _6.ReversedCharss
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = Console.ReadLine()[0];
            char secondLetter = Console.ReadLine()[0];
            char thirdLetter = Console.ReadLine()[0];

            Console.WriteLine($"{thirdLetter} {secondLetter} {firstLetter}");
        }
    }
}
