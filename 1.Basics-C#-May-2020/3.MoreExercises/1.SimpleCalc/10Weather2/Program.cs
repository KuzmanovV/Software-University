using System;

namespace _10Weather2
{
    class Program
    {
        static void Main(string[] args)
        {
            //26.00 - 35.00    Hot
            //20.1 - 25.9 Warm
            //15.00 - 20.00   Mild
            //12.00 - 14.9    Cool
            //5.00 - 11.9 Cold
            //Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown".
            double temperature = double.Parse(Console.ReadLine());
            if (temperature >= 26 && temperature <= 35)
            {
                Console.WriteLine("Hot");
            }
            else if (temperature >= 20.1 && temperature <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (temperature >= 15 && temperature <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (temperature >= 12 && temperature <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (temperature >= 5 && temperature <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
