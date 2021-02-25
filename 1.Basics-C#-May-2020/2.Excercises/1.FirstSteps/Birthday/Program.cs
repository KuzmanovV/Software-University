using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double rent = double.Parse(Console.ReadLine());
            //Торта  – цената ѝ е 20 % от наема на залата
            double cake = rent * 20 / 100.0;
            //Напитки – цената им е 45 % по - малко от тази на тортата
            double drinks = cake * (1 - 45 / 100.0);
            //Аниматор – цената му е 1 / 3 от цената за наема на залата
            double anim = rent * 1 / 3;
            Console.WriteLine(rent + cake + drinks + anim);

        }
    }
}
