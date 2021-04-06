using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string model;
        private int horsePower;
        private double cubicCentimeters;
        private int minHP;
        private int maxHP;

        protected Car(string model, int horsePower,double cubicCentimeters,int minHorsePower, int maxHorsePower)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
            MinHP = minHorsePower;
            MaxHP = maxHorsePower;
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length<4)
                {
                    throw new ArgumentException($"Model {Model} cannot be less than 4 symbols.");
                }

                model = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return horsePower;
            }
            private set
            {
                if (horsePower<MinHP && horsePower>MaxHP)
                {
                    throw new ArgumentException($"Invalid horse power: {horsePower}.");
                }

                horsePower = value;
            }
        }
        public int MinHP { get; private set; }
        public int MaxHP { get; private set; }
        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }
    }
}