namespace _4.BorderControl
{
    public class Robot: IMachine
    {
        public Robot(string model, int id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; set; }
        public int Id { get; set; }
    }
}