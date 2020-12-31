using System;

namespace _2.ASCIISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = Console.ReadLine()[0];
            char last = Console.ReadLine()[0];
            string collection = Console.ReadLine();
            int output = 0;

            foreach (char ch in collection)
            {
                if (ch>(char)first&& ch<last)
                {
                    output += ch;
                }
            }

            Console.WriteLine(output);
        }
    }
}
