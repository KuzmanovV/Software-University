using System;

namespace _7.Vending
{
    class Program
    {
        static void Main(string[] args)
        {
            double insertedAmount = 0;
            string command = Console.ReadLine();
            double collectedAmount = 0;
            string output = "";

            while (command != "Start")
            {
                insertedAmount = double.Parse(command);

                bool isValid = insertedAmount == 0.1 ||
                               insertedAmount == 0.2 ||
                               insertedAmount == 0.5 ||
                                 insertedAmount == 1 ||
                                  insertedAmount == 2;

                if (isValid)
                {
                    collectedAmount += insertedAmount;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedAmount}");
                }

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine().ToLower();
            double price = 0;

            while (secondCommand != "end")
            {
                switch (secondCommand)
                {
                    //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. 
                    // 2.0,     0.7,      1.5,     0.8,    1.0 
                    case "nuts": price = 2; break;

                    case "water": price = .7; break;

                    case "crisps": price = 1.5; break;

                    case "soda": price = .8; break;

                    case "coke": price = 1; break;

                    default: Console.WriteLine("Invalid product");
                        secondCommand = Console.ReadLine().ToLower();
                        continue; break;
                }

                if (price > collectedAmount)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    collectedAmount -= price;
                    Console.WriteLine($"Purchased {secondCommand}");
                }
                
                secondCommand = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {collectedAmount:f2}");
        }
    }
}
