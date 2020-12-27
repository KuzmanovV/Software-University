using System;

namespace _6.MiddleCaracter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length%2 == 0)
            {
                Print2Middles(input);
            }
            else
            {
                Print1Middle(input);
            }
        }

        private static void Print1Middle(string input)
        {
            Console.Write(input[input.Length / 2]);
        }

        private static void Print2Middles(string input)
        {
            Console.Write(input[input.Length/2-1]);
            Console.WriteLine(input[input.Length/2]);
        }
    }
}
