using System;
using System.Collections.Generic;
using System.Linq;


namespace _7.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                string[] comArgs = input.Split();
                Person person = new Person(comArgs[0], comArgs[1], int.Parse(comArgs[2]));
                persons.Add(person);
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons.OrderBy(x => x.Age)));
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
