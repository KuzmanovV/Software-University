namespace _1.Vehicles
{
    public class Truck: Vehicle
    {
        private const double truckAirconModifier = 1.6;
        public Truck(double quantity, double consumption) 
            : base(quantity, consumption, truckAirconModifier)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel*0.95);
        }
    }
}