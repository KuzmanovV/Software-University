using System;

namespace _6.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(width, height));
        }

        private static double Area(double width, double height)
        {
            return width * height;
        }
    }
}
