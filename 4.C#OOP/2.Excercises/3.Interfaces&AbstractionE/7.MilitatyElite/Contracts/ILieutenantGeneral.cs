using System.Collections.Generic;

namespace _7.MilitatyElite.Contracts
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivates(IPrivate @private);
    }
}