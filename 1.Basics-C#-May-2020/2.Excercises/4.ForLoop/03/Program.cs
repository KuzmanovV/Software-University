using System;

namespace ForCicle_Excersise
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine($"OddSum=0.00,");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                double oddMin = double.MaxValue;
                double oddMax = double.MinValue;
                double evenMin = double.MaxValue;
                double evenMax = double.MinValue;
                double evenSum = 0;
                double oddSum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double cNum = double.Parse(Console.ReadLine());

                    if (i % 2 == 1)
                    {
                        oddSum += cNum;

                        if (cNum < oddMin)
                        {
                            oddMin = cNum;
                        }

                        if (cNum > oddMax)
                        {
                            oddMax = cNum;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        evenSum += cNum;

                        if (cNum < evenMin)
                        {
                            evenMin = cNum;
                        }

                        if (cNum > evenMax)
                        {
                            evenMax = cNum;
                        }
                    }
                }

                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");

                if (n > 1)
                {
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }
                else
                {
                    Console.WriteLine($"EvenSum=0.00,");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
            }

        }
    }
}
