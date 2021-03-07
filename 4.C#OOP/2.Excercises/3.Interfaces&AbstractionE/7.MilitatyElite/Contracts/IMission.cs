using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Contracts
{
    public interface IMission
    {
        string codeName { get; }
        State state { get; }
        void CompleteMission();

    }
}