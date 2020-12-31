using System;
using System.Collections.Generic;
using System.Linq;

namespace MEPrep290220G1
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            int[] attendances = new int[students];

            if (lectures > 0 && students > 0)
            {
                for (int i = 0; i < students; i++)
                {
                    attendances[i] = int.Parse(Console.ReadLine());
                }

                int maxAttendance = attendances.Max();


                Console.WriteLine($"Max Bonus: {Math.Ceiling(maxAttendance / lectures * (5 + bonus))}.");
                Console.WriteLine($"The student has attended {maxAttendance} lectures.");
            }
            else
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
            }
        }
    }
}
