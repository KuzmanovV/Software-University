using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());

            PrintInBetween(first, last);
        }

        private static void PrintInBetween(char first, char last)
        {
            if (first > last)
            {
                char cont = first;
                first = last;
                last = cont;
            }

            for (char i = (char)(first + 1); i < last; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
