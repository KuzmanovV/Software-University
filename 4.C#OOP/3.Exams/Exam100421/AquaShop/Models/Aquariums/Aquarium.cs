using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capacity;
        private LinkedList<IDecoration> decorations;
        private LinkedList<IFish> fishes;

        protected Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            decorations = new LinkedList<IDecoration>();
            fishes = new LinkedList<IFish>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }

                name = value;
            }
        }
        public int Capacity { get; private set; }
        public int Comfort => decorations.Sum(d => d.Comfort);
        public ICollection<IDecoration> Decorations => decorations;
        public ICollection<IFish> Fish => fishes;
        public void AddFish(IFish fish)
        {
            if (fishes.Count < Capacity)
            {
                fishes.AddLast(fish);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
        }

        public bool RemoveFish(IFish fish)
        {
            return fishes.Remove(fish);
        }

        public void AddDecoration(IDecoration decoration)
        {
            decorations.AddLast(decoration);
        }

        public void Feed()
        {
            foreach (var fish in fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({GetType().Name}):");

            if (fishes.Count == 0)
            {
                sb.AppendLine("none");
            }
            else
            {
                sb.AppendLine("Fish: ");

                List<IFish> listOfF = fishes.ToList();
                for (int i = 0; i < fishes.Count - 2; i++)
                {
                    sb.Append($"{listOfF[i].Name}, ");
                }
                sb.AppendLine(listOfF[fishes.Count - 1].Name);

                sb.AppendLine($"Decorations: {decorations.Count}");
                sb.AppendLine($"Comfort: {Comfort}");
            }

            return sb.ToString();
        }
    }
}