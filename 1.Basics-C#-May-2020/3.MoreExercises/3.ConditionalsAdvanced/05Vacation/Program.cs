using System;

namespace _05Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            Втори ред –  Сезон – текст "Summer" или "Winter"*/
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string loc = "";
            string place = "";
           
            if (budget<=1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "Summer": loc = "Alaska"; budget *=.65; break;
                    case "Winter": loc = "Morocco"; budget *=.45; break;
                }
            }
            else if (budget<=3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer": loc = "Alaska"; budget *=.8; break;
                    case "Winter": loc = "Morocco"; budget *=.6; break;
                }
            }
            else
            {
                place = "Hotel";
                budget *= .9;
                switch (season)
                {
                    case "Summer": loc = "Alaska"; break;
                    case "Winter": loc = "Morocco"; break;
                }
            }

            /*"{локацията} – {мястото за настаняване} – {цената}"
Цената трябва да е форматирана до вторият знак след десетичната запетая.*/
            Console.WriteLine($"{loc} - {place} - {budget:f2}");
        }
    }
}
