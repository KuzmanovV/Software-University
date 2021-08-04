using System;

namespace _13Ski
{
    class Program
    {
        static void Main(string[] args)
        {
           // Първи ред -дни за престой -цяло число в интервала[0...365]
//Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
//Трети ред -оценка - "positive"  или "negative"

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();
            double total = 0.0;
            if (days<10)
            {
                switch (room)
                {
                    case "room for one person": total = 18 * (days - 1);break;
                    case "apartment": total = 25 * (days - 1)*0.7;break;
                    case "president apartment": total = 35 * (days - 1)*0.9;break;
                }
            }
            else if (days>=10 && days<=15)
            {
switch (room)
                {
                    case "room for one person": total = 18 * (days - 1);break;
                    case "apartment": total = 25 * (days - 1)*0.65;break;
                    case "president apartment": total = 35 * (days - 1)*0.85;break;
                }
            }
            else if (days>15)
            {
switch (room)
                {
                    case "room for one person": total = 18 * (days - 1);break;
                    case "apartment": total = 25 * (days - 1)*0.5;break;
                    case "president apartment": total = 35 * (days - 1)*0.8;break;
                }
            }
            if (opinion== "positive")
            {
                total = total * 1.25;
            }
            else if (opinion== "negative")
            {
                total = total * 0.9;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
