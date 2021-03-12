using System;
using System.Collections.Generic;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Tiger: Feline
    {
        private static HashSet<string> BaseAllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };

        private const double BaseWeightModifier = 0.3;
        public Tiger(
            string name, 
            double weight, 
            string livingRegion,
            string breed)
            : base(BaseAllowedFoods, name, weight, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}