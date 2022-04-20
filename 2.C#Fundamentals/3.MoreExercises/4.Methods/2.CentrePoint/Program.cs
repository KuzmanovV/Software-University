using System;

namespace _2.CentrePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (Distanse(x1, y1) <= Distanse(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (Distanse(x1, y1) > Distanse(x2, y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
           
        }

        private static double Distanse(double x1, double y1)
        {
            return Math.Sqrt(Math.Round(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
                }
    }
}
