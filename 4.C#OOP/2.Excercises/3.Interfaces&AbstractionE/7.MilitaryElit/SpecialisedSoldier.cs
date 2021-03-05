namespace _7.MilitaryElit
{
    public class SpecialisedSoldier: ISoldier, IPrivate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}