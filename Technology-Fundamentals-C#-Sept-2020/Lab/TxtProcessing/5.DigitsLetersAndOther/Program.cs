using System;

namespace _5.DigitsLetersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string digits = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                    input = input.Remove(i, 1);
                    i--;
                }
            }

            string symbol = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    symbol += input[i];
                    input = input.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine($"{digits}\n{symbol}\n{input}");
        }
    }
}
