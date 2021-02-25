using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalGrade = 0;
            int presentations = 0;
            double allTotalGrades = 0;

            while (presentation!= "Finish")
            {
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                    allTotalGrades += grade;
                    presentations++;
                }

                Console.WriteLine($"{presentation} - {totalGrade/n:f2}.");
                totalGrade = 0;
                presentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {allTotalGrades/presentations:f2}.");
        }
    }
}
