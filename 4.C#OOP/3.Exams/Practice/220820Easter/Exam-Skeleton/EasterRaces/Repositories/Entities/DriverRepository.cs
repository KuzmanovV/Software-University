using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository: IRepository<IDriver>
    {
        private readonly IDictionary<string, IDriver> driversByName;

        public DriverRepository()
        {
            driversByName = new Dictionary<string, IDriver>();
        }
        public IDriver GetByName(string name)
        {
            IDriver driver = null;

            if (driversByName.ContainsKey(name))
            {
                driver = driversByName[name];
            }

            return driver;
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return driversByName.Values.ToList();
        }

        public void Add(IDriver model)
        {
            if (driversByName.ContainsKey(model.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists,model.Name));
            }

            driversByName.Add(model.Name,model);
        }

        public bool Remove(IDriver model)
        {
            return driversByName.Remove(model.Name);
        }
    }
}