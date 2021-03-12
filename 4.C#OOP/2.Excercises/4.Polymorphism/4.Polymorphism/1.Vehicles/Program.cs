using System;
using System.Dynamic;

namespace _1.Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var parts = Console.ReadLine().Split();
                var command = parts[0];
                var vehicleType = parts[1];
                var parameter = double.Parse(parts[2]);

                try
                {
                    if (vehicleType==nameof(Car))
                    {
                        ProcessCommand(car, command, parameter);
                    }
                    else if (vehicleType==nameof(Truck))
                    {
                        ProcessCommand(truck, command, parameter);
                    }
                    else
                    {
                        ProcessCommand(bus, command, parameter);
                    }
                }
                catch (Exception ex)
                when (ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {
                    vehicle.Drive(parameter);
                    Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else if (command=="DriveEmpty")
            {
                    ((Bus)vehicle).TurnOffAircon();
                    vehicle.Drive(parameter);
                    ((Bus)vehicle).TurnOnAircon();
                    Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else
            {
                vehicle.Refuel(parameter);
            }
        }

        private static Vehicle CreateVehicle()
        {
            var parts = Console.ReadLine().Split();

            var type = parts[0];
            var quantity = double.Parse(parts[1]);
            var consumption = double.Parse(parts[2]);
            var capacity = double.Parse(parts[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(quantity, consumption, capacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(quantity, consumption, capacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(quantity, consumption, capacity);
            }
            return vehicle;
        }
    }
}
