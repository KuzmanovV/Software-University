using System;

namespace _03Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            //2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            //3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            //4ти ред: брой работници – цяло число в интервала[1 … 20]
            int areaX = int.Parse(Console.ReadLine());
            double harvestY = double.Parse(Console.ReadLine());
            int volumeZ = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            double volumeProduced = areaX * harvestY * 0.4 / 2.5;
            if (volumeProduced>=volumeZ)
            {
                double left = volumeProduced - volumeZ;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(volumeProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(left)} liters left -> {Math.Ceiling(left/number)} liters per person.");
            }
            else if (volumeProduced < volumeZ)
            {
                double left = Math.Floor(volumeZ - volumeProduced);
                Console.WriteLine($"It will be a tough winter! More {left} liters wine needed.");
            }
        }
    }
}
