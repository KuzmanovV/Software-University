using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreTextProc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string name = "";
            string age = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int index = input.IndexOf('@');
                int indexEnd = input.IndexOf('|');
                name = input.Substring(index+1, indexEnd - index-1);
                
                int index1 = input.IndexOf('#');
                int indexEnd1 = input.IndexOf('*');
                age = input.Substring(index1+1, indexEnd1 - index1-1);
                
                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
