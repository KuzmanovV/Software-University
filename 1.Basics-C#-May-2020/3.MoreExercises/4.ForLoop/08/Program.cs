using System;
using System.ComponentModel.DataAnnotations;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double couple1 = 0;
            double couple2 = 0;
            double maxDiff = double.MinValue;
            double diff = 0;

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            couple1 = firstNum + secondNum;
            for (int i = 1; i < n; i++)
            {
                firstNum = double.Parse(Console.ReadLine());
                secondNum = double.Parse(Console.ReadLine());
                couple2 = firstNum + secondNum;
                if (couple1!=couple2)
                {
                    diff = Math.Abs(couple2 - couple1);
                    couple1 = couple2;
                    if (diff>maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }

            if (maxDiff>=diff)
            {
            Console.WriteLine($"No, maxdiff={maxDiff}");
            }
            else
            {
            Console.WriteLine($"Yes, value={couple1}");
            }

        }
    }
}
