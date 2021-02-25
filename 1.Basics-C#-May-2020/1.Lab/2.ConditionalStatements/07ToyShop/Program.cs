using System;

namespace _07ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double prPuzzle = 2.6;     
            int prDоll = 3;
            double prBear = 4.1;
            double prMin = 8.2;
            int prTruck = 2;
            double prTrip = double.Parse(Console.ReadLine());
            int Puzzles = int.Parse(Console.ReadLine());
            int Dolls = int.Parse(Console.ReadLine());
            int Bears = int.Parse(Console.ReadLine());
            int Mins = int.Parse(Console.ReadLine());
            int Trucks = int.Parse(Console.ReadLine());
            int Toys = Puzzles + Dolls + Bears + Mins + Trucks;
            double res = (Puzzles * prPuzzle + Dolls * prDоll + Bears * prBear +
                    Mins * prMin + Trucks * prTruck);
            if (Toys >= 50)
            {
                res = res * 0.75;
            }
            res = res * 0.9;
                if (res >= prTrip)
                {
                double leftMoney = res - prTrip;    
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
                }
                else
                {
                double neededMoney = prTrip - res;   
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
                }
            
        }
    }
}
