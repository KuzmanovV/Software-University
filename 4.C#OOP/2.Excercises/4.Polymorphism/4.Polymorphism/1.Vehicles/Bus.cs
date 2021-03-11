namespace _1.Vehicles
{
    public class Bus: Vehicle
    {
        private const double busAirconModifier = 1.4;
        public Bus(double quantity, double consumption, double capacity) 
            : base(quantity, consumption, capacity, busAirconModifier)
        {
        }

        public void TurnOnAircon()
        {
            AirconModifier = busAirconModifier;
        }

        public void TurnOffAircon()
        {
            AirconModifier = 0;
        }
    }
}