using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysN = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDayPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerson = double.Parse(Console.ReadLine());

            double[] daylyLoss = new double[daysN];

            for (int i = 0; i < daysN; i++)
            {
                daylyLoss[i] = double.Parse(Console.ReadLine());
            }

            double water = daysN * countPlayers * waterPerDayPerson;
            double food = daysN * countPlayers * foodPerDayPerson;

            for (int i = 0; i < daysN; i++)
            {
                energy -= daylyLoss[i];

                if (energy <= 0)
                {
                    break;
                }

                if ((i + 1) % 2 == 0)
                {
                    energy *= 1.05;
                    water *= .7;
                }

                if ((i + 1) % 3 == 0)
                {
                    energy *= 1.1;
                    if (countPlayers > 0)
                    {
                        food -= food / countPlayers;
                    }
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
            }
        }
    }
}
