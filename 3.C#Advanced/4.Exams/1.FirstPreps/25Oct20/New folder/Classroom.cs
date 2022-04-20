using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count => students.Count();
        public string RegisterStudent(Student student)
        {
            if (students.Count >= Capacity)
            {
                return "No seats in the classroom";
            }
            else
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student == null)
            {
                return "Student not found";
            }
            
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Subject: {subject}");
            result.Append("Students:");

            if (students.FirstOrDefault(s => s.Subject == subject) == null)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                foreach (var item in students.Where(s => s.Subject == subject))
                {
                    result.Append($"{Environment.NewLine}{item.FirstName} {item.LastName}");
                }
            }

            return result.ToString();
        }
        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
