using System;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine(Output(input, times));
        }

        private static string Output(string input, int times)
        {
            string[] output = new string[times];
            output[0] = input;
            for (int i = 1; i < times; i++)
            {
                output[i] = output[i-1];
            }
            return string.Join("", output);
        }
    }
}
