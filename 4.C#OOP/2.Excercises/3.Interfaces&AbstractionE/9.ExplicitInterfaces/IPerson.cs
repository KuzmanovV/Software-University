﻿namespace _9.ExplicitInterfaces
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetName();
    }
}