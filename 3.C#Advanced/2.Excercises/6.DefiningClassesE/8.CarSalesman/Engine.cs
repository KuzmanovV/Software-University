using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
    public class Engine
    {
        //•	Model
        //•	Power
        //•	Displacement
        //•	Efficiency

        public Engine(string engineModel, int power)
        {
            EngineModel = engineModel;
            Power = power;
            Efficiency = "n/a";
        }
        public Engine(string engineModel, int power, int displacement)
            : this(engineModel, power)
        {
            Displacement = displacement;
        }
        public Engine(string engineModel, int power, string efficiency)
            : this(engineModel, power)
        {
            Efficiency = efficiency;
        }
        public Engine(string engineModel, int power, int displacement, string efficiency)
            : this(engineModel, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public string EngineModel { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
