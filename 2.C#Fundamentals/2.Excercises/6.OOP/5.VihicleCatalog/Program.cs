using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.VihicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Catalogue> cars = new List<Catalogue>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                Catalogue car = new Catalogue(tokens[0].ToLower(), tokens[1], tokens[2], int.Parse(tokens[3]));
                cars.Add(car);
                input = Console.ReadLine();
            }

            string inputModel = Console.ReadLine();

            while (inputModel != "Close the Catalogue")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.Find(x => x.Model == inputModel)));

                inputModel = Console.ReadLine();
            }

            List<Catalogue> carsOnly = cars.Where(x => x.Type == "Car").ToList();
            List<Catalogue> trucksOnly = cars.Where(x => x.Type == "Truck").ToList();

            double carAv = 0;
            double truckAv = 0;
            
            if (carsOnly.Count>0)
            {
                carAv = carsOnly.Sum(x => x.HorsePower)*1.0 / carsOnly.Count;
            }
            
            if (trucksOnly.Count>0)
            {
                truckAv = trucksOnly.Sum(x => x.HorsePower)*1.0 / trucksOnly.Count;
            }
            
            Console.WriteLine($"Cars have average horsepower of: {carAv:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAv:f2}.");
        }
    }

    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsePower)
        {
            if (type == "car")
            {
                Type = "Car";
            }
            else
            {
                Type = "Truck";
            }
            
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
        }
    }
}
