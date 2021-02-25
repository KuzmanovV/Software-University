using System;

namespace _02ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int expected = int.Parse(Console.ReadLine());
            string price = Console.ReadLine();
            double totalCash = 0; ;
            double totalBank = 0;
            double total = totalBank+totalCash;
            int serial = 0;
            int counterCash = 0;
            int counterBank = 0;


            while (price!="End")
            {
                double priceParsed = double.Parse(price);
                serial++;

                if (serial%2!=0 && priceParsed<=100)
                {
                    totalCash += priceParsed;
                    Console.WriteLine("Product sold!");
                    counterCash++;
                }
                else if (serial % 2 == 0 && priceParsed >= 10)
                {
                    totalBank += priceParsed;
                    Console.WriteLine("Product sold!");
                    counterBank++;
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }

                total = totalCash + totalBank;
                if (total>=expected)
                {
                    Console.WriteLine($"Average CS: {totalCash/counterCash:f2}");
                    Console.WriteLine($"Average CC: {totalBank/counterBank:f2}");
                    break;
                }
                
                price = Console.ReadLine();
            }

            if (total<expected)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }

        }
    }
}
