using System;

namespace _07Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Брой магнолии – цяло число в интервала[0 … 50]
            //Брой зюмбюли – цяло число в интервала[0 … 50]
            //Брой рози – цяло число в интервала[0 … 50]
            //Брой кактуси – цяло число в интервала[0 … 50]
            //Цена на подаръка – реално число в интервала[0.00 … 500.00]
            int magnolia = int.Parse(Console.ReadLine());
            int hyacint = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double revenue = (magnolia*3.25+hyacint*4+rose*3.5+cactus*8)*0.95;
            if (revenue>=price)
            {
                Console.WriteLine($"She is left with {Math.Floor(revenue-price)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(price-revenue)} leva.");
            }
        }
    }
}
