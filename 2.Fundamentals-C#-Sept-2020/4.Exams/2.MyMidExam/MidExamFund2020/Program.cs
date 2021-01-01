using System;

namespace MidExamFund2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double freeFours = (students / 5) * priceFlour;
            double costFlour = students * priceFlour - freeFours;
            double costEgg = students * priceEgg * 10;
            double costApron = Math.Ceiling(students * 1.2) * priceApron;

            double cost = costApron + costEgg + costFlour;

            if (cost>budget)
            {
                Console.WriteLine($"{cost-budget:f2}$ more needed.");
            }
            else
            {
                Console.WriteLine($"Items purchased for {cost:f2}$.");
            }
        }
    }
}
