using System;
using System.Xml;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdds = 0;
            int sumEvens = 0;
            string output1 = "";
            string output2 = "";

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumEvens += numbers;
                }
                else
                {
                    sumOdds += numbers;
                }
            }

            if (sumOdds == sumEvens)
            {
                output1 = "Yes";
                output2 = $"Sum = {sumEvens}";
            }
            else
            {
                output1 = "No";
                output2 = $"Diff = {Math.Abs(sumEvens-sumOdds)}";
            }
            
            Console.WriteLine(output1);
            Console.WriteLine(output2);
        }
    }
}
