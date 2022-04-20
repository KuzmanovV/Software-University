using System;
using System.Collections.Generic;
using System.Text;

namespace _6.SpeedRacing
{
    public class Car
    {
//        •	string Model
//•	double FuelAmount
//•	double FuelConsumptionPerKilometer
//•	double Travelled distance

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelled { get; set; }

        public bool Drive(double travelled)
        {
            double neededFuel = travelled * this.FuelConsumptionPerKilometer;

            if (neededFuel>this.FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFuel;
            this.Travelled += travelled;
            return true;
        }
    }
}
