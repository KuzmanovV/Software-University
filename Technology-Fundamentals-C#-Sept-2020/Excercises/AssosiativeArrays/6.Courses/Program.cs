using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" : ");

                if (!courses.ContainsKey(cmdArgs[0]))
                {
                    courses.Add(cmdArgs[0], new List<string> { cmdArgs[1] });
                }
                else
                {
                    courses[cmdArgs[0]].Add(cmdArgs[1]);
                }
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                
                foreach (var student in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
