using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double final = 0;

            foreach (var item in input)
            {
                double output = 0;
                char first = item[0];
                char last = item[item.Length - 1];
                double num = double.Parse(item.Substring(1, item.Length - 2));

                if (alpha.Contains(first))
                {
                    output += num / (alpha.IndexOf(first) + 1);
                }
                else
                {
                    string upper = first.ToString().ToUpper();
                    output = num * (alpha.IndexOf(upper) + 1);
                }

                if (alpha.Contains(last))
                {
                    output -= (alpha.IndexOf(last) + 1);
                }
                else
                {
                    string upper = last.ToString().ToUpper();
                    output += (alpha.IndexOf(upper) + 1);
                }

                final += output;
            }

            Console.WriteLine($"{final:f2}");
        }
    }
}
