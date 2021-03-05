namespace _4.BorderControl
{
    public class Human: IHuman
    {
        public Human(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    }
}