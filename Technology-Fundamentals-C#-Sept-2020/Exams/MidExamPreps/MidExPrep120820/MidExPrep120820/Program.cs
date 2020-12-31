using System;

namespace MidExPrep120820
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            double partsPrice = 0;

            while (input != "special" && input != "regular")
            {
                partsPrice = double.Parse(input);

                if (partsPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += partsPrice;
                }

                input = Console.ReadLine();
            }

            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double taxes = total * 0.2;
                Console.WriteLine($"Congratulations you've just bought a new computer!" +
                    $"\nPrice without taxes: {total:f2}$\nTaxes: {taxes:f2}$\n -----------");

                if (input == "special")
                {
                    Console.WriteLine($"Total price: {total*1.2*.9:f2}$");
                }
                else if (input == "regular")
                {
                    Console.WriteLine($"Total price: {total*1.2:f2}$");
                }
            }
        }
    }
}
