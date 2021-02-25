using System;

namespace _09LeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftCol = 0;
            int rightCol = 0;
            string output = "";

            for (int i = 0; i < n; i++)
            {
                int l = int.Parse(Console.ReadLine());
                leftCol += l;
            }
            for (int i = 0; i < n; i++)
            {
                int r = int.Parse(Console.ReadLine());
                rightCol += r;
            }

            if (leftCol==rightCol)
            {
                output = $"Yes, sum = {leftCol}";
            }
            else
            {
                output = $"No, diff = {Math.Abs(leftCol-rightCol)}";
            }
            
            Console.WriteLine(output);
        }
    }
}
