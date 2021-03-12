using System;
using System.Collections.Generic;
using System.Xml;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Hen : Bird
    {
        private const double BaseWeightModifier = 0.35;

        private static HashSet<string> baseAllowedFoods = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Fruit),
            nameof(Seeds),
            nameof(Vegetable)
        };
        public Hen(
            string name, double weight,
            double wingSize)
            : base(baseAllowedFoods, name, weight, BaseWeightModifier, wingSize)
        {
        }

        public override string Sound()
        {
            return "Cluck";
        }
    }
}