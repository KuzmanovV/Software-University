using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Child child = new Child(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(child);
        }
    }
}