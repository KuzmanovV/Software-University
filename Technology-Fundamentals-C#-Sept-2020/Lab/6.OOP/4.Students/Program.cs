using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string student = Console.ReadLine();

            List<Students> students = new List<Students>();

            while (student!="end")
            {
                string[] input = student.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Students studentObj = new Students();
                
                    studentObj.FirstName = input[0];
                    studentObj.LastName = input[1];
                    studentObj.Age = int.Parse(input[2]);
                    studentObj.HomeTown = input[3];

                students.Add(studentObj);
                
                student = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Students studentObj in students)
            {
                if (studentObj.HomeTown == city)
                {
                    Console.WriteLine($"{studentObj.FirstName} {studentObj.LastName} is {studentObj.Age} years old.");
                }
            }
        }
        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
