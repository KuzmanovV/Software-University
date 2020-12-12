using System;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==input[i-1])
                {
                    input = input.Remove(i-1, 1);
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
