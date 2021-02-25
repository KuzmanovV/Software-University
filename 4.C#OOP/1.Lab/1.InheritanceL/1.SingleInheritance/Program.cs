using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Puppy puppy = new Puppy();
            Cat cat = new Cat();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            cat.Eat();
            cat.Meow();
        }
    }
}
