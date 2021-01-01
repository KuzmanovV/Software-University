using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int output = 0;

            string bigger = input[0];
            string smaller = input[1];

            if (smaller.Length>bigger.Length)
            {
                bigger = input[1];
                smaller = input[0];
            }

            for (int i = 0; i < smaller.Length; i++)
            {
                output += (smaller[i] * bigger[i]);
            }

            for (int i = smaller.Length; i < bigger.Length; i++)
            {
                output += bigger[i];
            }

            Console.WriteLine(output);
        }
    }
}
