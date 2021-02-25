using System;

namespace _04Rentacar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            Втори ред –  Сезон – текст "Summer" или "Winter"*/
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string clas = "";
            string type = "";
            
            if (budget<=100)
            {
                clas = "Economy class";
                switch (season)
                {
                    case "Summer": type = "Cabrio"; budget *= .35; break;
                    case "Winter": type = "Jeep"; budget *= .65; break;
                }
            }
            else if (budget<=500)
            {
                clas = "Compact class";
                switch (season)
                {
                    case "Summer": type = "Cabrio"; budget *= .45; break;
                    case "Winter": type = "Jeep"; budget *= .8; break;
                }
            }
            else
            {
                clas = "Luxury class";
                type = "Jeep";
                budget *= .9;
            }

            Console.WriteLine($"{clas}"); //"Economy class", "Compact class" или "Luxury class"
            Console.WriteLine($"{type} - {budget:f2}"); // "Cabrio" или "Jeep"
        }
    }
}
