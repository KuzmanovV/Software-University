using System;

namespace _3.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (Longiness(x1, y1, x2, y2) >= Longiness(x3, y3, x4, y4))
            {
                if (Distanse(x1, y1) <= Distanse(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (Distanse(x1, y1) <= Distanse(x2, y2))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double Longiness(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Round(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)));
        }

        private static double Distanse(double x1, double y1)
        {
            return Math.Sqrt(Math.Round(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
        }
    }
}
