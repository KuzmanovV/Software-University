using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 8)
            {
                Environment.Exit(0);
            }
            else
            {
                for (int i = 8; i <= n; i++)
                {
                    if (SumIsDivisibleBy8(i) && AtLeastOneOdd(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static bool SumIsDivisibleBy8(int i)
        {
            string number = i.ToString();
            int sum = 0;

            for (int j = 0; j < number.Length; j++)
            {
                int intForSum = int.Parse(number[j].ToString());
                sum += intForSum;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool AtLeastOneOdd(int i)
        {
            string number = i.ToString();

            for (int j = 0; j < number.Length; j++)
            {
                if (number[j] % 2 == 1)
                {
                    return true;
                    break;
                }
            }

            return false;
        }
    }
}

