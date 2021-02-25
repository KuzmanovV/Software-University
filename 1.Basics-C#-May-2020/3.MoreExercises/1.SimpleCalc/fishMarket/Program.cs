using System;

namespace fishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //Пети ред – килограма миди. Цяло число в интервала[0... 100]
            double prMackerel = double.Parse(Console.ReadLine());
            double prSprat = double.Parse(Console.ReadLine());
            double qyPalamis = double.Parse(Console.ReadLine());
            double prPalamis = 1.6 * prMackerel;
            double qyScad = double.Parse(Console.ReadLine());
            double prScad = 1.8 * prSprat;
            int qyMussel = int.Parse(Console.ReadLine());
            double prMussel = 7.5;
            //Паламуд – 60 % по - скъп от скумрията
            //Сафрид – 80 % по - скъп от цацата
            //Миди – 7.50 лв.за килограм
            double res = prPalamis * qyPalamis + prScad * qyScad + prMussel * qyMussel;
            Console.WriteLine($"{res:f2}");
//Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на 
//Георги, за да си плати сметката.Закръглено до вторият знак след десетичната запетая(1.2457-> 1.25)
        }
    }
}
