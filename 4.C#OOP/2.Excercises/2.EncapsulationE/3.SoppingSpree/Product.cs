using System;
namespace _3.SoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty");
                name = value;
            }
        }
        public decimal Cost
        {
            get => cost;
            set
            {
                Validator.ThrowIfNumberIsNegative(value, "Money cannot be negative");
                cost = value;
            }
        }
    }
}