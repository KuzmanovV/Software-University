using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private Dictionary<string, IAquarium> aquariums;

        public Controller()
        {
            this.aquariums = new Dictionary<string, IAquarium>();
            decorations = new DecorationRepository();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                aquariums.Add(aquariumName, new FreshwaterAquarium(aquariumName));
                return $"Successfully added {aquariumType}.";
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquariums.Add(aquariumName, new SaltwaterAquarium(aquariumName));
                return $"Successfully added {aquariumType}.";
            }

            return "Invalid aquarium type.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                decorations.Add(new Ornament());
                return $"Successfully added {decorationType}.";
            }
            if (decorationType == "Plant")
            {
                decorations.Add(new Plant());
                return $"Successfully added {decorationType}.";
            }

            throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            Decoration decoration = decorations.FindByType(decorationType);
            if (decoration == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            aquariums[aquariumName].AddDecoration(decoration);
            decorations.Remove(decoration);
            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType== "FreshwaterFish")
            {
                Fish fish = new FreshwaterFish(fishName,fishSpecies,price);
                aquariums[aquariumName].AddFish(fish);

                if (aquariums[aquariumName].GetType().Name== "SaltwaterAquarium")
                {
                    return "Water not suitable.";
                }

                return $"Successfully added {fishType} to {aquariumName}.";
            }
            if (fishType == "SaltwaterFish")
            {
                Fish fish = new SaltwaterFish(fishName, fishSpecies, price);
                aquariums[aquariumName].AddFish(fish);
                
                if (aquariums[aquariumName].GetType().Name == "FreshwaterAquarium")
                {
                    return "Water not suitable.";
                }

                return $"Successfully added {fishType} to {aquariumName}.";
            }

            throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
        }

        public string FeedFish(string aquariumName)
        {
            aquariums[aquariumName].Feed();
            return $"Fish fed: {aquariums[aquariumName].Fish.Count}";
        }

        public string CalculateValue(string aquariumName)
        {
            decimal value = aquariums[aquariumName].Fish.Sum(f => f.Price)
                            + aquariums[aquariumName].Decorations.Sum(d => d.Price);

            return $"The value of Aquarium {aquariumName} is {value}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aq in aquariums.Values)
            {
                sb.AppendLine(aq.GetInfo());
            }

            return sb.ToString();
        }
    }
}