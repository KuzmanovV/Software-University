using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] output = input[input.Length-1].Split(".");

            Console.WriteLine($"File name: {output[0]}\nFile extension: {output[1]}");
        }
    }
}
