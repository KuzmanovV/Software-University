using System;

namespace _5.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string sms = "";

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)

            {
                int n = int.Parse(Console.ReadLine());

                int index = 0;
                int lastDigit = 0;
                int digitCounter = 0;

                while (n != 0)
                {
                    lastDigit = n % 10;
                    n /= 10;
                    digitCounter++;
                }

                if (lastDigit == 8 || lastDigit == 9)
                {
                    index = (lastDigit - 2) * 3 + digitCounter;
                }
                else
                {
                    index = (lastDigit - 2) * 3 + digitCounter - 1;
                }

                if (index == -7)
                {
                    sms += " ";
                }
                else
                {
                    sms += (char)(index + 97);

                }

            }

            Console.WriteLine(sms);
        }
    }
}
