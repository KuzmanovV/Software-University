namespace _1.Vehicles
{
    public class Car: Vehicle
    {
        private const double carAirconModifier = 0.9;

        public Car(double quantity, double consumption, double capacity)
            : base(quantity, consumption, capacity, carAirconModifier)
        {
        }
    }
}