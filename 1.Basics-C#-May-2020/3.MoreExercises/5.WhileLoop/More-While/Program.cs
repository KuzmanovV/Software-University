using System;

namespace More_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            int detergent = detergentBottles * 750;
            string units = Console.ReadLine();
            int counter = 0;
            int counterPots = 0;
            int counterDishes = 0;

            while (units!="End")
            {
                int parsedUnits = int.Parse(units);
                counter++;
                
                if (counter%3==0)
                {
                    detergent -= parsedUnits * 15;
                    counterPots += parsedUnits;
                }
                else
                {
                    detergent -= parsedUnits * 5;
                    counterDishes += parsedUnits;
                }

                if (detergent<0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                    break;
                }

                units = Console.ReadLine();
            }

            if (detergent>=0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{counterDishes} dishes and {counterPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
        }
    }
}
