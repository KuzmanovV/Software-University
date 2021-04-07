using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository: IRepository<ICar>
    {
        private readonly IDictionary<string, ICar> carsByModel;

        public CarRepository()
        {
            this.carsByModel = new Dictionary<string, ICar>();
        }
        
        public ICar GetByName(string name)
        {
            ICar car = null;

            if (carsByModel.ContainsKey(name))
            {
                car = carsByModel[name];
            }

            return car;
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return carsByModel.Values.ToList();
        }

        public void Add(ICar model)
        {
            if (carsByModel.ContainsKey(model.Model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model.Model));
            }
            
            carsByModel.Add(model.Model,model);
        }

        public bool Remove(ICar model)
        {
            return carsByModel.Remove(model.Model);
        }
    }
}