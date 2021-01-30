using System;

namespace _5.FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people[i] = new Person()
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = GetCondition(condition, age);
            Action<Person> printDelegate = GetPrinter(format);

            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    printDelegate(person);
                }
            }

        }

        static Func<Person, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;
                default: return null;
            }
        }

        static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case "name age":
                    return f =>
                          {
                              Console.WriteLine($"{f.Name} - {f.Age}");
                          };
                case "name":
                    return f =>
                          {
                              Console.WriteLine(f.Name);
                          };
                case "age":
                    return f =>
                          {
                              Console.WriteLine(f.Age);
                          };
                default:
                    return null;
            }
        }
    }
}
