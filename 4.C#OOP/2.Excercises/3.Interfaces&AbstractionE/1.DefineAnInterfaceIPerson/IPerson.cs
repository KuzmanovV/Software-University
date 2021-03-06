namespace PersonInfo
{
    public interface IPerson: IBirthable, IIdentifiable
    {
        public string Name { get; }
        public int Age { get; }
    }
}