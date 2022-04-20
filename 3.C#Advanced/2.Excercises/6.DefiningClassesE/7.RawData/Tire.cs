using System;
using System.Collections.Generic;
using System.Text;

namespace _7.RawData
{
    public class Tire
    {
        public Tire(double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
        {
            Pressure1 = pressure1;
            Age1 = age1;
            Pressure2 = pressure2;
            Age2 = age2;
            Pressure3 = pressure3;
            Age3 = age3;
            Pressure4 = pressure4;
            Age4 = age4;
        }
        public double Pressure1 { get; set; }
        public int Age1 { get; set; }
        public double Pressure2 { get; set; }
        public int Age2 { get; set; }
        public double Pressure3 { get; set; }
        public int Age3 { get; set; }
        public double Pressure4 { get; set; }
        public int Age4 { get; set; }
    }
}
