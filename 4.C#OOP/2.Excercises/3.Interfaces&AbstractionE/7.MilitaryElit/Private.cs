namespace _7.MilitaryElit
{
    public class Private: IPrivate, ISoldier
    {
        public decimal Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}