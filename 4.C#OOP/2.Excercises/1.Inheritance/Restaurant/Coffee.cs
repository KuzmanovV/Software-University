using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        private const double DefaultCoffeeMilliliters = 50;
        private const decimal DefaultCoffeePrice = 3.5M;
        private decimal CoffeePrice = 3.50M;
        public Coffee(string name, double	caffeine)
            : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; set; }
    }
}
