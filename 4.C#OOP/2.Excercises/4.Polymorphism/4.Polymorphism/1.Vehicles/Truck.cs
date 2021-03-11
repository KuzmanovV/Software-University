using System;

namespace _1.Vehicles
{
    public class Truck: Vehicle
    {
        private const double truckAirconModifier = 1.6;
        public Truck(double quantity, double consumption, double capacity) 
            : base(quantity, consumption, capacity, truckAirconModifier)
        {
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (fuel + Quantity > Capacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }

            Quantity += fuel*0.95;
        }
    }
}