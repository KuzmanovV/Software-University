using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver:IDriver
    {
        private string name;

        protected Driver(string name)
        {
            Name = name;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {Name} cannot be less than 5 symbols.");
                }

                name = value;
            }
        }
        public ICar Car { get; private set; }
        public int NumberOfWins { get; private set; }
        public bool CanParticipate { get; private set; }
        public void WinRace()
        {
            NumberOfWins++;
        }
        public void AddCar(ICar car)
        {
            if (car==null)
            {
                throw new ArgumentNullException("Car cannot be null.");
            }

            Car = car;
            CanParticipate = true;
        }
    }
}