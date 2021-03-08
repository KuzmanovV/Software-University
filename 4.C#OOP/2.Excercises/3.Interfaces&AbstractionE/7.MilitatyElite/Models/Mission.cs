using _7.MilitatyElite.Contracts;
using _7.MilitatyElite.Enums;

namespace _7.MilitatyElite.Models
{
    public class Mission: IMission
    {
        public Mission(string codeName, State state)
        {
            this.codeName = codeName;
            this.state = state;
        }
        public string codeName { get; private set; }
        public State state { get; private set; }
        public void CompleteMission()
        {
            state = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {codeName} State: {state}";
        }
    }
}