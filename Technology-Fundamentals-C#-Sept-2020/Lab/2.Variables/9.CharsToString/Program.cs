using System;

namespace _9.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = Console.ReadLine()[0];
            char secondLetter = Console.ReadLine()[0];
            char thirdLetter = Console.ReadLine()[0];

            string output = "";
            output += firstLetter+secondLetter;

            Console.WriteLine(output);
        }
    }
}
