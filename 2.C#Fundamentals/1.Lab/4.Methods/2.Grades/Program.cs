using System;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade(double.Parse(Console.ReadLine()));
        }

        static void Grade(double gr)
        {
            if (gr <=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (gr >= 3 && gr <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (gr >= 3.5 && gr <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (gr >= 4.5 && gr <=5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
