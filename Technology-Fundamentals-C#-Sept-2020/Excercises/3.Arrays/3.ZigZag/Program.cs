using System;
using System.Linq;

namespace _3.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] upperArr = new string[n];
            string[] lowerArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                if (i%2 == 0)
                {
                    upperArr[i] = input[0];
                    lowerArr[i] = input[1];
                }
                else
                {
                    upperArr[i] = input[1];
                    lowerArr[i] = input[0];
                    
                }
            }

            Console.WriteLine(string.Join(" ",upperArr));
            Console.WriteLine(string.Join(" ",lowerArr));
        }
    }
}
