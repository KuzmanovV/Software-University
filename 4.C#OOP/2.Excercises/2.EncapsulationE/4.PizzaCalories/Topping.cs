using System;

namespace _4.PizzaCalories
{
    public class Topping
    {
        private string typeOfTopping;
        private int toppingWeight;
        private const int minWeight = 1;
        private const int maxWeight = 50;

        public Topping(string typeOfTopping, int toppingWeight)
        {
            TypeOfTopping = typeOfTopping;
            ToppingWeight = toppingWeight;
        }

        public string TypeOfTopping
        {
            get => typeOfTopping;
            private set
            {
                string valueAsLower = value.ToLower();
                if (valueAsLower != "meat" && valueAsLower != "veggies" && valueAsLower != "cheese" && valueAsLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                typeOfTopping = value;
            }
        }

        public int ToppingWeight
        {
            get => toppingWeight;
            set
            {
                Validator.ThroughIfInvalidNumber(minWeight, maxWeight, value, $"{typeOfTopping} weight should be in the range[{minWeight}..{maxWeight}].");

                toppingWeight = value;
            }
        }

        public double GetCalories()
        {
            var modifier = GetModifier();
            return 2 * toppingWeight * modifier;
        }

        private double GetModifier()
        {
            switch (typeOfTopping.ToLower())
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                default:
                    return 0.9;
            }
        }
    }
}