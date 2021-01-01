using System;

namespace _1.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(0, input.Length);
                string word = input[i];
                input[i] = input[index];
                input[index] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
