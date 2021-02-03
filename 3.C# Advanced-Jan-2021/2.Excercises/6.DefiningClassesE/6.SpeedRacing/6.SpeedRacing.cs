using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car currentCar = new Car
                {
                    Model = input[0],
                    FuelAmount = double.Parse(input[1]),
                    FuelConsumptionPerKilometer = double.Parse(input[2])
                };

                cars.Add(currentCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split();

                Car current = cars.FirstOrDefault(m => m.Model == cmd[1]);

                if (!current.Drive(double.Parse(cmd[2])))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.Travelled}");
            }
        }
    }
}
