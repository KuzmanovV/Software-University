using System;

namespace _4.PizzaCalories
{
    public class Dough
    {
        private const string invalidDoughMessege = "Invalid type of dough.";
        private const int minDoughWeight = 1;
        private const int maxDoughWeight = 200;
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType,string bakingTechnique,int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
        public string FlourType
        {
            get => flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(invalidDoughMessege);
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(invalidDoughMessege);
                }

                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                Validator.ThroughIfInvalidNumber(minDoughWeight, maxDoughWeight, value, $"Dough weight should be in the range [{minDoughWeight}..{maxDoughWeight}].");

                weight = value;
            }
        }

        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetbakingTechniqueModifier();
            return 2*weight * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetbakingTechniqueModifier()
        {
            switch (bakingTechnique.ToLower())
            {
                case "crispy":return 0.9; break;
                case "chewy": return 1.1; break;
                default: return 1;
            }
        }

        private double GetFlourTypeModifier()
        {
            if (flourType.ToLower()== "white")
            {
                return 1.5;
            }

            return 1;
        }
    }
}