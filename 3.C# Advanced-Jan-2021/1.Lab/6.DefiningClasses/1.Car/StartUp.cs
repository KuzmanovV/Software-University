using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = "BMW";
            string model = "X6";
            int year = 2000;
            double fuelQuantity = 50;
            double fuelConsumption = 5;
            
            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
