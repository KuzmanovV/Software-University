namespace _6.FoodShortage
{
    public interface ICitizen: IPerson
    {
        public string Id { get; }
        public string Birthdate { get; }
    }
}