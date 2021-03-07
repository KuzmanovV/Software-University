using System;
using System.Collections.Generic;
using System.Text;
using _7.MilitatyElite.Contracts;

namespace _7.MilitatyElite.Models
{
    public class LieutenantGeneral: Private, ILieutenantGeneral
    {
        private List<IPrivate> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();
        public void AddPrivates(IPrivate @private)
        {
            privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            
            foreach (var @private in Privates)
            {
                sb.AppendLine($"  {@private}");
            }

            return sb.ToString().Trim();
        }
    }
}