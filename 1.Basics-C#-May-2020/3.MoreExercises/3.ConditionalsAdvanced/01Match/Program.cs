using System;

namespace NestedCond_More
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На първия ред е бюджетът – реално число в интервала [1 000.00 ... 1 000 000.00]
            На втория ред е категорията – "VIP" или "Normal"
            На третия ред е броят на хората в групата – цяло число в интервала [1 ... 200]*/
            double budget = double.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double left = 0;
            double tickets = 0;
            if (ticket=="VIP")
            {   
            tickets = people * 499.99;
            }
            else
            {
            tickets = people * 249.99;
            }
            /*От 1 до 4 – 75% от бюджета.
От 5 до 9 – 60% от бюджета.
От 10 до 24 – 50% от бюджета.
От 25 до 49 – 40% от бюджета.
50 или повече – 25% от бюджета.*/
            if (people<5)
            {
                left = budget * 0.25;
            }
            else if (people<10)
            {
                left = budget * 0.4;
            }
            else if (people<25)
            {
                left = budget * 0.5;
            }
            else if (people<50)
            {
                left = budget * 0.6;
            }
            else
            {
                left = budget * 0.75;
            }
            if (left>=tickets)
            {
                Console.WriteLine($"Yes! You have {left - tickets:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {tickets - left:f2} leva.");
            }
        }
    }
}
