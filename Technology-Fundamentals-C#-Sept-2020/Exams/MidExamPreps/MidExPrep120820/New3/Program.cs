using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string guess;
            int mooves = 0;

            while ((guess = Console.ReadLine()) != "end")
            {
                int[] guesses = guess.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                mooves++;

                if (guesses[0] < 0
                 || guesses[0] >= input.Count
                 || guesses[1] < 0
                 || guesses[1] >= input.Count
                 || guesses[0] == guesses[1])
                {
                    input.Insert(input.Count / 2, $"-{mooves}a");
                    input.Insert(input.Count / 2, $"-{mooves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (input[guesses[0]] == input[guesses[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[guesses[0]]}!");
                        string forRemoval = input[guesses[0]];
                        input.RemoveAll(x => x == forRemoval);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (input.Count < 1)
                {
                    break;
                }
            }

            if (input.Count > 1)
            {
                Console.WriteLine($"Sorry you lose :(\n{string.Join(' ', input)}");
            }
            else
            {
                Console.WriteLine($"You have won in {mooves} turns!");
            }
        }
    }
}
