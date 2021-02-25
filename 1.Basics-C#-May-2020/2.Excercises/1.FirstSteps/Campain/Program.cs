using System;

namespace Campain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Торта - 45 лв.
            //Гофрета - 5.80 лв.
            //Палачинка – 3.20 лв.
           int days = int.Parse(Console.ReadLine());
           int bakers = int.Parse(Console.ReadLine());
           int cakes = int.Parse(Console.ReadLine());
           int waffels = int.Parse(Console.ReadLine());
           int pancakes = int.Parse(Console.ReadLine());
           double bakersProfit = ((cakes * 45) + (waffels * 5.8) + (pancakes * 3.2))*days*bakers;
           double total = (1 - 1.0 / 8) * bakersProfit;
           Console.WriteLine(total);
        }
    }
}
