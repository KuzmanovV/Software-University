using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Contracts
{
    public interface ISpecialisedSoldier: IPrivate
    {
        Corps Corps { get; }
    }
}