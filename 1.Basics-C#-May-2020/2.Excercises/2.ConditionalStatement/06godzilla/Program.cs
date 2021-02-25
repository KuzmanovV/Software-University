using System;

namespace _06godzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceCloudsOne = double.Parse(Console.ReadLine());
            double scenery = budget * 0.1;
            if (people>150)
            {
                priceCloudsOne = priceCloudsOne * 0.9;
            }
            double needed = people * priceCloudsOne+scenery;
            if (needed>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needed - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-needed:f2} leva left.");
            }
        }
    }
}
