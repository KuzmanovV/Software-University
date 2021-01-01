using System;

namespace _5.mULTIPLICATIONsIGN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (ThePositiveProduct(num1, num2, num3))
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
        }

        private static bool ThePositiveProduct(int num1, int num2, int num3)
        {
            if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                return true;
            }
            else
            {
                if (num1 > 0 && num2 < 0 && num3 < 0)
                {
                    return true;
                }
                else
                {
                    if (num1 < 0 && num2 < 0 && num3 > 0)
                    {
                        return true;
                    }
                    else
                    {
                        if (num1 < 0 && num2 > 0 && num3 < 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}
