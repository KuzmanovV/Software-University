using System;

namespace _05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
 Втори ред –  Един от двата възможни сезона: „summer” или “winter”*/
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string journey = "";
           
            if (budget<=100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer": budget = budget*0.3; journey = "Camp"; break;  
                    case "winter": budget = budget * 0.7; journey = "Hotel"; break;  
                }
            }
            else if (budget<=1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer": journey = "Camp"; budget= budget * 0.4; break;  
                    case "winter": journey = "Hotel"; budget = budget * 0.8; break;  
                }
            }
            else
            {
                destination = "Europe";
                budget = budget * 0.9;
                journey = "Hotel"; 
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{journey} - {budget:f2}");
        }
    }
}
