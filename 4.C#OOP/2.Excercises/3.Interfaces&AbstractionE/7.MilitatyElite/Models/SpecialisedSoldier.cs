using _7.MilitatyElite.Contracts;
using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Models
{
    public abstract class SpecialisedSoldier: Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(
            string id,
            string firstName, 
            string lastName, 
            decimal salary, 
            Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }
        public override string ToString()
        {
            return base.ToString()
                +$"Corps: {Corps}";
        }
    }
}