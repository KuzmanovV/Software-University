using System;

namespace ArraysLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[]
                            {"Monday",
                            "Tuesday",
                            "Wednesday",
                            "Thursday",
                            "Friday",
                            "Saturday",
                            "Sunday"};

            int day = int.Parse(Console.ReadLine());

            if (day>0 && day<8)
            {
            Console.WriteLine(week[day-1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
