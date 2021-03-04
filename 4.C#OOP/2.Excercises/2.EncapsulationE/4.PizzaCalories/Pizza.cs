using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private const int minSymbols = 1;
        private const int maxSymbols = 15;
        private const int maxToppings = 10;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (value.Length<1 || value.Length>15)
                {
                    throw new ArgumentException($"Pizza name should be between {minSymbols} and {maxSymbols} symbols.");
                }

                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count==maxToppings)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{maxToppings}].");
            }
            
            toppings.Add(topping);
        }

        public double GetCalories()
        {
            return dough.GetCalories() + toppings.Sum(t => t.GetCalories());
        }
    }
}