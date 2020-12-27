using System;

namespace _9.Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                IsPalindrom(input);
                input = Console.ReadLine();
            }
        }

        private static void IsPalindrom(string input)
        {
            bool isEqual = false;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
