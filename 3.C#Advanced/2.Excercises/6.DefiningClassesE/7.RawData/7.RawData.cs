using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.RawData
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
                
                Engine currentEngine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                
                Cargo currentCargo = new Cargo(int.Parse(input[3]), input[4]);
                
                Tire currentTires = new Tire(double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12]));
                
                Car currentCar = new Car(input[0], currentEngine, currentCargo, currentTires);

                cars.Add(currentCar);
            }

            string lastCommand = Console.ReadLine();
            if (lastCommand=="fragile")
            {
                foreach (var item in cars.Where(c=>c.Cargo.CargoType=="fragile").Where(c=>(c.Tire.Pressure1<1 || c.Tire.Pressure2 < 1 || c.Tire.Pressure3 < 1 || c.Tire.Pressure1 < 1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower >250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}

