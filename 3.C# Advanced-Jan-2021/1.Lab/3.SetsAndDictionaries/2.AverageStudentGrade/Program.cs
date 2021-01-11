using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!students.ContainsKey(input[0]))
                {
                    students.Add(input[0], new List<decimal> { decimal.Parse(input[1])});
                    //students[input[0]] = new List<decimal> { decimal.Parse(input[1]) };
                }
                else
                {
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(' ', item.Value)} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
