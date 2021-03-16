using System;
using System.Threading.Channels;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int MaxStat = 100;
        private const int MinStat = 0;
        //endurance, sprint, dribble, passing and shooting
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name
        {
            get => name;
            set
            {
                Validator.ThrowIfNullOrWhiteSpace(value, "A name should not be empty.");

                name = value;
            }
        }
        public int Endurance
        {
            get => endurance;
            set
            {
                Validator.ThrowIfNotInRange(MinStat, MaxStat, value, $"{nameof(Endurance)} should be between 0 and 100.");

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            set
            {
                Validator.ThrowIfNotInRange(MinStat, MaxStat, value, $"{nameof(Sprint)} should be between 0 and 100.");

                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            set
            {
                Validator.ThrowIfNotInRange(MinStat, MaxStat, value, $"{nameof(Dribble)} should be between 0 and 100.");

                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            set
            {
                Validator.ThrowIfNotInRange(MinStat, MaxStat, value, $"{nameof(Passing)} should be between 0 and 100.");

                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            set
            {
                Validator.ThrowIfNotInRange(MinStat, MaxStat, value, $"{nameof(Shooting)} should be between 0 and 100.");

                shooting = value;
            }
        }

        public double AverageSkill => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
    }
}