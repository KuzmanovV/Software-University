using System;

namespace _10.Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            GetMultipleOfEvenAndOdds(number);
        }

        private static void GetMultipleOfEvenAndOdds(string v)
        {
            Console.WriteLine(GetSumOfEvenDigits(v) * GetSumOfOddDigits(v));
        }

        private static int GetSumOfEvenDigits(string v)
        {
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {

                if (v[i] / 2 == 0)
                {
                    sum += v[i];
                }
            }

            return sum;
        }

        private static int GetSumOfOddDigits(string v)
        {
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {

                if (v[i] / 2 != 0)
                {
                    sum += v[i];
                }
            }

            return sum;
        }
    }
}
