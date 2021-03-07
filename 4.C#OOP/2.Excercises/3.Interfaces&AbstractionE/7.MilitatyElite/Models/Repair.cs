using _7.MilitatyElite.Contracts;

namespace _7.MilitatyElite.Models
{
    public class Repair: IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.partName = partName;
            this.hoursWorked = hoursWorked;
        }
        public string partName { get; private set; }
        public int hoursWorked { get; private set; }
        public override string ToString()
        {
            return $"Part Name: {this.partName} Hours Worked: {this.hoursWorked}";
        }
    }
}