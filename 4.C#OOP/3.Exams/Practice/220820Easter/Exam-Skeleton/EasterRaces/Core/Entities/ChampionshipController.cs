using EasterRaces.Core.Contracts;
using EasterRaces.Models.Drivers.Entities;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController: IChampionshipController
    {
        public string CreateDriver(string driverName)
        {
            var driver = new Driver(driverName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            throw new System.NotImplementedException();
        }

        public string CreateRace(string name, int laps)
        {
            throw new System.NotImplementedException();
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            throw new System.NotImplementedException();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            throw new System.NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new System.NotImplementedException();
        }
    }
}