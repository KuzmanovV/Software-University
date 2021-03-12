using System;
using System.Collections.Generic;
using System.Xml;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Owl : Bird
    {
        private const double BaseWeightModifier = 0.25;

        private static HashSet<string> baseAllowedFoods = new HashSet<string>()
        {
            nameof(Meat)
    };
        public Owl(
            string name, double weight,
            double wingSize)
            : base(baseAllowedFoods, name, weight, BaseWeightModifier, wingSize)
        {
        }

        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}