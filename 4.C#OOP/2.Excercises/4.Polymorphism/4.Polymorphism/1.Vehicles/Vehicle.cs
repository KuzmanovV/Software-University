using System;
using System.ComponentModel;

namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        private double quantity;
        protected Vehicle(double quantity, double consumption, double capacity, double airconModifier)
        {
            Consumption = consumption;
            Capacity = capacity;
            Quantity = quantity;
            AirconModifier = airconModifier;
        }
        protected double AirconModifier { get; set; }

        public double Quantity
        {
            get => quantity;
            protected set
            {
                if (value>Capacity)
                {
                    quantity = 10;
                }
                else
                {
                    quantity = value;
                }
            }
        }
        public double Consumption { get; private set; }
        public double Capacity { get; private set; }

        public void Drive(double distance)
        {
            double requiredFuel = distance * (Consumption + AirconModifier);

            if (requiredFuel <= Quantity)
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
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (fuel + Quantity > Capacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }

            Quantity += fuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Quantity:f2}";
        }
    }
}