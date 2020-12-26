using System;

namespace _4.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            foreach (var word in banned)
            {
                string asterisks = new string('*', word.Length);

                input = input.Replace(word, asterisks);
            }

            Console.WriteLine(input);
        }
    }
}
