﻿using _7.MilitatyElite.Contracts;

namespace _7.MilitatyElite.Models
{
    public abstract class Soldier: ISoldier
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} ";
        }
    }
}