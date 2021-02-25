using System;

namespace Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            //	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            //Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            //Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFr = int.Parse(Console.ReadLine());
            double total = (vegetables * kgVeg + fruits * kgFr) / 1.94;
            Console.WriteLine($"{total:f2}");
        }
    }
}
