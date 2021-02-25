using System;
using System.Xml;

namespace _04Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет на групата – цяло число в интервала[1…8000]
            //Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //Брой рибари – цяло число в интервала[4…18]
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double price = 0.0;
            switch (season)
            {
                case "Spring": price = 3000; break;
                    case "Summer": price = 4200; break;
                    case "Autumn": price = 4200; break;
                    case "Winter": price = 2600; break;
            }
            if (number <= 6)
            {
                price *= 0.9;
            }
            else if (number <= 11)
            {
                price *= 0.85;
            }
            else //12+
            {
                price *= 0.75;
            }
            switch (season)
            {
                case "Spring":
                case "Summer":
                case "Winter": 
                    if (number % 2 == 0)
                    {
                    price *= 0.95;
                    }
                    break;
            }
           
            string output = "";
                    if (price<=budget)
                    {
                        output = $"Yes! You have {budget - price:f2} leva left.";
                    }
                    else
                    {
                        output = $"Not enough money! You need {price - budget:f2} leva.";
                    }
                    Console.WriteLine(output);
        }
    }
}
