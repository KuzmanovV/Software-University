using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            VowelsCount(input);
        }

        private static void VowelsCount(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y': sum++; break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
