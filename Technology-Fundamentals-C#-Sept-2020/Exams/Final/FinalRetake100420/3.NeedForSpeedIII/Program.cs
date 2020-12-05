using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");

                cars[tokens[0]] = new List<int>() { int.Parse(tokens[1]), int.Parse(tokens[2]) };
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmd = command.Split(" : ");
                string car = cmd[1];
                int mileage = cars[car][0];
                int fuel = cars[car][1];

                switch (cmd[0])
                {
                    case "Drive":
                        int fuelNeeded = int.Parse(cmd[3]);
                        int targetDistance = int.Parse(cmd[2]);
                        if (cars[car][1] >= fuelNeeded)
                        {
                            cars[car][1] -= fuelNeeded;
                            cars[car][0] += targetDistance;
                            Console.WriteLine($"{car} driven for {targetDistance} kilometers. " +
                                $"{fuelNeeded} liters of fuel consumed.");

                            if (cars[car][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        break;
                    case "Refuel":
                        int refieled = int.Parse(cmd[2]);
                        int oldFuelQty = cars[car][1];
                        cars[car][1] += refieled;
                        cars[car][1] = cars[car][1] > 75 ? 75 : cars[car][1];
                        Console.WriteLine($"{car} refueled with {75-oldFuelQty} liters");
                        break;
                    case "Revert":
                        int km = int.Parse(cmd[2]);
                        cars[car][0] -= km;
                        cars[car][0] = cars[car][0] < 10000 ? 10000 : cars[car][0];
                        if (cars[car][0] > 10000)
                        {
                            Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
