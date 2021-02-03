using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
    public class Car
    {
        //• Model
        //•	Engine
        //•	Weight 
        //•	Color
        public Car(string model, Engine engineModel)
        {
            Model = model;
            EngineModel = engineModel;
            Color = "n/a";
        }
        public Car(string model, Engine engineModel, string color)
            : this(model, engineModel)
        {
            Color = color;
        }
        public Car(string model, Engine engineModel, int weight)
            : this(model, engineModel)
        {
            Weight = weight;
        }
        public Car(string model, Engine engineModel, int weight, string color)
                        : this(model, engineModel)
        {
            Weight = weight;
            Color = color;
        }
        public string Model { get; set; }
        public Engine EngineModel { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
    }
}
