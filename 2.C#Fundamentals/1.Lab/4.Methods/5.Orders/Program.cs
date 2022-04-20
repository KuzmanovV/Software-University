using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00

            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            Total(product, qty);
        }

        static void Total(string prod, int qt)
        {
            switch (prod)
            {
                case "coffee": Console.WriteLine($"{ qt * 1.5:f2}"); break;
                case "water": Console.WriteLine($"{ qt:f2}"); break;
                case "coke": Console.WriteLine($"{ qt * 1.4:f2}"); break;
                case "snacks": Console.WriteLine($"{ qt * 2:f2}"); break;
            }
        }
    }
}
