using System;

namespace _1.Vehicles
{
    public class Car: IAutomobile
    {
        public Car(double quantity, double consumption)
        {
            Quantity = quantity;
            Consumption = consumption*0.9;
        }
        public double Quantity { get; private set; }
        public double Consumption { get; private set; }
        public void Drive(int distance)
        {
            double planedExpence=distance*Consumption;

            if (planedExpence<=Quantity)
            {
                Quantity -= planedExpence;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(int fuel)
        {
            throw new System.NotImplementedException();
        }
    }
}