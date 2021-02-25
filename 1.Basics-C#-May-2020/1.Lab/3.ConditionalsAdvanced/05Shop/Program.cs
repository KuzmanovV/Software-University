using System;

namespace _05Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double total = 0.0;
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee": total = qty * 0.5; break;
                    case "water": total = qty * 0.8; break;
                    case "beer": total = qty * 1.2; break;
                    case "sweets": total = qty * 1.45; break;
                    default: total = qty * 1.6; break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": total = qty * 0.4; break;
                    case "water": total = qty * 0.7; break;
                    case "beer": total = qty * 1.15; break;
                    case "sweets": total = qty * 1.30; break;
                    default: total = qty * 1.5; break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee": total = qty * 0.45; break;
                    case "water": total = qty * 0.7; break;
                    case "beer": total = qty * 1.1; break;
                    case "sweets": total = qty * 1.35; break;
                    default: total = qty * 1.55; break;
                }
            }
            Console.WriteLine(total);
        }
            
        
    }
}
