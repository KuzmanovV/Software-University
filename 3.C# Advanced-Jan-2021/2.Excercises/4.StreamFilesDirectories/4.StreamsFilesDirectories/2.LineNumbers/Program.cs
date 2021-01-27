using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("TextFile1.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = 0;
                int marks = 0;

                foreach (var ch in lines[i])
                {
                    if (char.IsLetter(ch))
                    {
                        letters++;
                    }
                    else if (char.IsPunctuation(ch))
                    {
                        marks++;
                    }
                }

                File.AppendAllText("../../../TextOutput.txt", $"Line {i+1}: {lines[i]} " +
                    $"({letters})({marks}){Environment.NewLine}");
            }
        }
    }
}
