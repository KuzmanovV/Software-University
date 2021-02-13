using System;
using System.Collections.Generic;

namespace _5.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmd = command.Split();
                Person person = new Person(cmd[0], int.Parse(cmd[1]), cmd[2]);
                persons.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Person target = persons[index];

            int matches = 0;
            int notEqual = 0;
            foreach (var person in persons)
            {
                if (target.CompareTo(person)==0)
                {
                    matches++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (matches==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
            Console.WriteLine($"{matches} {notEqual} {persons.Count}");
            }
        }
    }
}
