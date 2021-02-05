using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 2)
                {
                    Engine currentEngine = new Engine(input[0], int.Parse(input[1])); engines.Add(currentEngine);

                }
                else if (input.Length == 4)
                {
                    Engine currentEngine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                    engines.Add(currentEngine);
                }
                else
                {
                    int thirdParameter = 0;
                    if (int.TryParse(input[2], out thirdParameter))
                    {
                        Engine currentEngine = new Engine(input[0], int.Parse(input[1]), thirdParameter);
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        Engine currentEngine = new Engine(input[0], int.Parse(input[1]), input[2]);
                        engines.Add(currentEngine);
                    }
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine neededEngineModel = null;
                foreach (var item in engines.Where(e => e.EngineModel == input[1]))
                {
                    neededEngineModel = item;
                }

                if (input.Length == 2)
                {
                    Car currentCar = new Car(input[0], neededEngineModel);
                    cars.Add(currentCar);

                }
                else if (input.Length == 4)
                {
                    Car currentCar = new Car(input[0], neededEngineModel, int.Parse(input[2]), input[3]);
                    cars.Add(currentCar);
                }
                else
                {
                    int thirdParameter = 0;
                    if (int.TryParse(input[2], out thirdParameter))
                    {
                        Car currentCar = new Car(input[0], neededEngineModel, thirdParameter);
                        cars.Add(currentCar);
                    }
                    else
                    {
                        Car currentCar = new Car(input[0], neededEngineModel, input[2]);
                        cars.Add(currentCar);
                    }
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.EngineModel.EngineModel}:");
                Console.WriteLine($"    Power: {item.EngineModel.Power}");
                
                if (item.EngineModel.Displacement == 0)
                {
                    Console.WriteLine($"  Displacement: n/a");
                }
                else
                {
                Console.WriteLine($"    Displacement: {item.EngineModel.Displacement}");
                }

                Console.WriteLine($"    Efficiency: {item.EngineModel.Efficiency}");
                
                if (item.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {item.Weight}");
                }
                
                Console.WriteLine($"  Color: {item.Color}");
            }
        }
    }
}
