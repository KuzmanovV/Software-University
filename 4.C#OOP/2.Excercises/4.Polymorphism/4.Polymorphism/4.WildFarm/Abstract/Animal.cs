using System;
using System.Collections.Generic;

namespace _4.WildFarm.Abstract
{
    public abstract class Animal
    {
        protected Animal(HashSet<string> allowedFoods, string name, double weight, double weightModifier)
        {
            AllowedFoods = allowedFoods;
            Name = name;
            Weight = weight;
            WeightModifier = weightModifier;
        }
        public HashSet<string> AllowedFoods { get; }
        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public double WeightModifier { get; private set; }
        public abstract string Sound();

        public void Eat(Food food)
        {
            if (!AllowedFoods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;

            Weight += food.Quantity * WeightModifier;
        }
    }
}