using System.Collections.Generic;

namespace _7.MilitatyElite.Contracts
{
    public interface IEngineer: ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}