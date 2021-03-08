using System.Collections.Generic;
using System.Text;
using _7.MilitatyElite.Contracts;
using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Models
{
    public class Commando: SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;
        public Commando(
            string id, 
            string firstName, 
            string lastName, 
            decimal salary, 
            Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => missions.AsReadOnly();
        public void AddMission(IMission mission)
        {
            missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission}");
            }

            return sb.ToString().Trim();
        }
    }
}