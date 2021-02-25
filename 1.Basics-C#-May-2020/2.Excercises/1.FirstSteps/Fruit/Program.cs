using System;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            double prStraw = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double rasp = double.Parse(Console.ReadLine());
            double straw = double.Parse(Console.ReadLine());
            //Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            //цената на малините е на половина по - ниска от тази на ягодите;
            double prRasp = prStraw / 2.0;
            //цената на портокалите е с 40 % по - ниска от цената на малините;
            double prOranges = prRasp * (1 - 40 / 100.0);
            //цената на бананите е с 80 % по - ниска от цената на малините.
            double prBananas = prRasp * (1 - 80 / 100.0);
            //парите, които са необходими на Мария.
            double res = prStraw * straw + prBananas * bananas + prOranges * oranges + prRasp * rasp;
            Console.WriteLine(Math.Round(res,2));
        }
    }
}
