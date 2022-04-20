using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4];
            {
                new Tire(1, 2.5);
                new Tire(1, 2.1);
                new Tire(1, 0.5);
                new Tire(1, 2.3);
            };

            //Engine engine = new Engine(560, 6300);

            //var car = new Car("Lambo", "Urus", 2010, 250, 9, engine, tires);

            //Console.WriteLine(car.WhoAmI());

            string tireInfo;
            while ((tireInfo = Console.ReadLine())!= "No more tires")
            {
                string[] cmd = tireInfo.Split();
                foreach (var item in tires)
                {
                    item.Year = cmd[]
                }
            }
        }
    }
}
