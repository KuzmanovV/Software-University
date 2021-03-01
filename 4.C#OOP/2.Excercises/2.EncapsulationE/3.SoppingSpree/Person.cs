using System;
using System.Collections.Generic;

namespace _3.SoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name,int money)
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
                if (value=="")
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }
        public int Money
        {
            get => money;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

    }
}