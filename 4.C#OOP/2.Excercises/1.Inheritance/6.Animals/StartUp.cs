using System;
namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstLine;
            while ((firstLine = Console.ReadLine()) != "Beast!")
            {
                string[] secondLine = Console.ReadLine().Split();
                string name = secondLine[0];
                int age = int.Parse(secondLine[1]);
                string gender = secondLine[2];

                if (string.IsNullOrEmpty(name) || age<0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (firstLine)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        Console.WriteLine(dog.ProduceSound());
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        Console.WriteLine(frog.ProduceSound());
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        Console.WriteLine(cat.ProduceSound());
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat);
                        Console.WriteLine(tomcat.ProduceSound());
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
