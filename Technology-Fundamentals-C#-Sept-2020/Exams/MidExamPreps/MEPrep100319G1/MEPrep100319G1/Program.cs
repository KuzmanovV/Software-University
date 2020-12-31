using System;

namespace MEPrep100319G1
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double prFuelKm = double.Parse(Console.ReadLine());
            double prFoodPersonDay = double.Parse(Console.ReadLine());
            double prRoomPersonDay = double.Parse(Console.ReadLine());
            double[] distanceDay = new double[days];

            bool notEnoughMoney = false;
            double hotelDay = prRoomPersonDay * people;

            if (days>10)
            {
                hotelDay *= .75;
            }
            double total = 0;

            for (int i = 0; i < days; i++)
            {
                distanceDay[i] = double.Parse(Console.ReadLine());
                total += (prFuelKm * distanceDay[i])+ (people*prFoodPersonDay)+ hotelDay;

                if (i!=0 && (i+1)%3==0)
                {
                    total *= 1.4;
                }
                
                if (i!=0 && (i+1)%5==0)
                {
                    total *= 1.4;
                }
                
                if (i!=0 && (i+1)%7==0)
                {
                    total = total - total/people;
                }

                if (total>budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {total-budget:f2}$ more.");
                    notEnoughMoney = true;
                    break;
                }
            }

            if (!notEnoughMoney)
            {
                Console.WriteLine($"You have reached the destination. You have {budget-total:f2}$ budget left.");
            }

        }
    }
}
