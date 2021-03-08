﻿using System.Collections.Generic;
using System.Text;
using _7.MilitatyElite.Contracts;
using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Models
{
    public class Engineer: SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;
        public Engineer(
            string id, 
            string firstName, 
            string lastName, 
            decimal salary, 
            Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => repairs.AsReadOnly();
        public void AddRepair(IRepair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  {repair}");
            }

            return sb.ToString().Trim();
        }
    }
}