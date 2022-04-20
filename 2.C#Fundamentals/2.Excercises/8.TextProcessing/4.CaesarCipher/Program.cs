using System;
using System.Text;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            foreach (var ch in input)
            {
                output.Append((char)(ch + 3));
            }

            Console.WriteLine(output);
        }
    }
}
