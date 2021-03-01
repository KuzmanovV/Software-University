using System;
namespace _3.SoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }
        public int Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                cost = value;
            }
        }
    }
}