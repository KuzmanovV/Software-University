namespace _1.Vehicles
{
    public interface IAutomobile
    {
        double Quantity { get; }
        double Consumption { get; }

        public void Drive(int distance);
        public void Refuel(int fuel);
    }
}