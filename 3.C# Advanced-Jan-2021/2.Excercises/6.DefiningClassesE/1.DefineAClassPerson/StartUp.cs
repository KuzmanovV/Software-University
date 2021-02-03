using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person currentPerson = new Person(input[0], int.Parse(input[1]));
                people.Add(currentPerson);
            }

            foreach (var man in people.Where(m=>m.Age>30).OrderBy(m=>m.Name))
            {
                Console.WriteLine($"{man.Name} - {man.Age}");
            }
        }
    }
}
