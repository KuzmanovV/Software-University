using System;

namespace _11FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double total = 0.0;
            if (day=="Monday" || day=="Tuesday" || day=="Wednesday" ||day=="Thursday" || day=="Friday")
            {
                switch (fruit)
                {
                    case "banana": total = qty * 2.5; break;
                    case "apple": total = qty * 1.2; break;
                    case "orange": total = qty * 0.85; break;
                    case "grapefruit": total = qty * 1.45; break;
                    case "kiwi": total = qty * 2.7; break;
                    case "pineapple": total = qty * 5.5; break;
                    case "grapes": total = qty * 3.85; break;
                }
            }
            else if (day=="Saturday"||day=="Sunday")
            {
                    switch (fruit)
                     {
                    case "banana": total = qty * 2.7; break;
                    case "apple": total = qty * 1.25; break;
                    case "orange": total = qty * 0.9; break;
                    case "grapefruit": total = qty * 1.6; break;
                    case "kiwi": total = qty * 3; break;
                    case "pineapple": total = qty * 5.6; break;
                    case "grapes": total = qty * 4.2; break;
                    }
            }
            if (total!=0.0)
            {
                Console.WriteLine($"{total:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
           
        }
    }
}
