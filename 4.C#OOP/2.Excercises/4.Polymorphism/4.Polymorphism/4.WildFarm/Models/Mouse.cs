using System;
using System.Collections.Generic;

namespace _4.WildFarm.Models
{
    public class Mouse: Mammal
    {
        private const double BaseWeightModifier = 0.1;

        private static HashSet<string> BaseAllowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(
            string name, 
            double weight, 
            string livingRegion)
            : base(BaseAllowedFoods, name, weight, BaseWeightModifier, livingRegion)
        {
        }

        public override string Sound()
        {
            return "Squeak";
        }
    }
}