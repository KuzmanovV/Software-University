using System;

namespace _06Truck
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            Втори ред –  Километри на месец – реално число в интервала [10.00...20000.00]*/
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double salary = 0;

            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary = km * .75; break;
                    case "Summer": salary = km * .9; break;
                    case "Winter": salary = km * 1.05; break;
                }
            }
            else if (km<=10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary = km * .95; break;
                    case "Summer": salary = km * 1.1; break;
                    case "Winter": salary = km * 1.25; break;
                }
            }
            else
            {
            salary = km * 1.45;
            }

            Console.WriteLine($"{salary * .9*4:f2}");
        }
    }
}
