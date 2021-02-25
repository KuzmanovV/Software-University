using System;

namespace _04Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double res = 0;
            if (n<20 && time=="day")
            {
                res = 0.7 + n * 0.79;
            }
            else if (n<20 && time=="night")
            {
                res = 0.7 + n * 0.9;
            }
            else if (n<100)
            {
                res = n * 0.09;
            }
            else
            {
                res = n * 0.06;
            }
            Console.WriteLine($"{ res:f2}");
        }
    }
}
