using System;

namespace MEPrep050720
{
    class Program
    {
        static void Main(string[] args)
        {
            int emplOne = int.Parse(Console.ReadLine());
            int emplTwo = int.Parse(Console.ReadLine());
            int emplThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = emplOne + emplTwo + emplThree;
            int hours = 0;

            while (students > 0)
            {
                students -= studentsPerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
