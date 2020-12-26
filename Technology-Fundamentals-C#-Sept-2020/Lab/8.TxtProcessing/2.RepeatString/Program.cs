using System;
using System.Text;

namespace _2.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder output = new StringBuilder();

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    output.Append(word);
                }
            }
            //string output = "";

            //for (int i = 0; i < cmd.Length; i++)
            //{
            //    for (int j = 0; j < cmd[i].Length; j++)
            //    {
            //        output += cmd[i];
            //    }
            //}

            Console.WriteLine(output);
        }
    }
}
