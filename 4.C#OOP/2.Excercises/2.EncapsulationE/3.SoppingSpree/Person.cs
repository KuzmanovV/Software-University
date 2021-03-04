using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
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
        public decimal Money
        {
            get => money;
            set
            {
                Validator.ThrowIfNumberIsNegative(value, "Money cannot be negative");
                money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > Money)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }
            bag.Add(product);
            Money -= product.Cost;
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", bag.Select(p => p.Name))}";
            }
        }
    }
}