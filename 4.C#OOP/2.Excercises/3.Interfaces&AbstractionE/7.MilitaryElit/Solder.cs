namespace _7.MilitaryElit
{
    public class Solder: ISoldier
    {
        public Solder(int id,string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}