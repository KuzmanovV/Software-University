namespace PersonInfo
{
    public class Pet: IPet
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            Birthdate = birthdate;
        }
        public string Name { get; private set; }
        public string Birthdate { get; private set; }
    }
}