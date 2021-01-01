using System;
using System.Text;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    bomb += int.Parse(input[i+1].ToString());
                    continue;
                }

                if (bomb>0)
                {
                input = input.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
