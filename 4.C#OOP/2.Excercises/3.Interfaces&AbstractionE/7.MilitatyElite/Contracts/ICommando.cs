using System.Collections.Generic;

namespace _7.MilitatyElite.Contracts
{
    public interface ICommando: ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}