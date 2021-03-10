using System;

namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double quantity, double consumption, double airconModifier)
        {
            Quantity = quantity;
            Consumption = consumption;
            AirconModifier = airconModifier;
        }
        private double AirconModifier { get; set; }
        public double Quantity { get; private set; }
        public double Consumption { get;  private set; }

        public void Drive(double distance)
        {
            double requiredFuel = distance * (Consumption+AirconModifier);

            if (requiredFuel<=Quantity)
            {
                Quantity -= requiredFuel;
            }
            else
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double fuel)
        {
            Quantity += fuel;
        }
    }
}