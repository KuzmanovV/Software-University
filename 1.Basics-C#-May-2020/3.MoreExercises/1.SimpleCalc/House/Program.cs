using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            //x – височината на къщата – реално число в интервала[2...100]
            //y – дължината на страничната стена – реално число в интервала[2...100]
            //h – височината на триъгълната стена на прокрива – реално число в интервала[2...100]
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            // зелената боя е 1 литър за 3.4 м2, а на червената – 1 литър за 4.3 м2.
            double normGreen = 3.4;
            double normRed = 4.3;
            double areaGreen = 2 * x * x + 2 * y * x - 2 * 1.2 - 2 * 1.5 * 1.5;
            double areaRed = x * h + 2 * x * y;
            double resGreen = areaGreen / normGreen;
            double resRed = areaRed / normRed;
            Console.WriteLine($"{resGreen:f2}");
            Console.WriteLine($"{resRed:f2}");
//Литрите зелена боя
//Литритe червена боя

        }
    }
}
