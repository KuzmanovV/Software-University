using System;
using System.Collections.Generic;

namespace _4.WildFarm.Models
{
    public class Dog: Mammal
    {
        private const double BaseWeightModifier = 0.4;

        private static HashSet<string> BaseAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Dog(
            string name, 
            double weight, 
            string livingRegion)
            : base(BaseAllowedFoods, name, weight, BaseWeightModifier, livingRegion)
        {
        }

        public override string Sound()
        {
            return "Woof!";
        }
    }
}