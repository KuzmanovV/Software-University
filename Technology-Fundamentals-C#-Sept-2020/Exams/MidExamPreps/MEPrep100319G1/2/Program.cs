using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            double budget = double.Parse(Console.ReadLine());
            double newItemPrice = 0;
            double newBudget = 0;
            double profit = 0;

            for (int i = 0; i < items.Length; i++)
            {
                string[] type = items[i].Split("->", StringSplitOptions.RemoveEmptyEntries);
                double price = double.Parse(type[1]);
                bool goodPrice = false;

                switch (type[0])
                {
                    case "Clothes":
                        if (price<=50)
                        {
                            goodPrice = true;
                        }
                        break;
                    case "Shoes":
                        if (price<=35)
                        {
                            goodPrice = true;
                        }
                        break;
                    case "Accessories": 
                        if (price<=20.5)
                        {
                            goodPrice = true;
                        }
                        break;
                }

                if (goodPrice && price<=budget)
                {
                    budget -= price;
                    profit += (price * .4);
                    newItemPrice = (price * 1.4);
                    Console.Write($"{newItemPrice:f2} ");
                    newBudget += newItemPrice;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");

            if ((newBudget+budget)<150)
            {
                Console.WriteLine("Time to go.");
            }
            else
            {
                Console.WriteLine("Hello, France!");
            }
        }
    }
}
