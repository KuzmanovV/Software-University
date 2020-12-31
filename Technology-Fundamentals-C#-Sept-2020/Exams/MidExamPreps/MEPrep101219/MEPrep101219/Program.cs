using System;

namespace MEPrep101219
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double saved = 0;
            double savingsPerMonth = .25 * price;

            for (int i = 1; i <= months; i++)
            {
                if (i%2==1 && i!=1)
                {
                    saved *= .84;
                }
                
                if (i%4==0)
                {
                    saved *= 1.25;
                }
                
                saved += savingsPerMonth;
            }

            double dif = saved - price;

            if (dif>=0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {dif:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(dif):f2}lv. more.");
            }
        }
    }
}
