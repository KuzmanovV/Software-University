using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_ME
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                            .Split()
                            .ToList();

            string textInput = Console.ReadLine();

            List<string> output = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                int code = 0;

                for (int j = 0; j < input[i].Length; j++)
                {
                    char c = input[i];
                    code += c[j];
                }
                output.Add(textInput[textInput.Length % code].ToString());
            }
            Console.WriteLine(string.Join("", output));
        }



    }
}

