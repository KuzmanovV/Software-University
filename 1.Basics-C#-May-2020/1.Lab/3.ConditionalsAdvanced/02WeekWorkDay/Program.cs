using System;

namespace _02WeekWorkDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Saturday": 
                case "Sunday": 
                
                    Console.WriteLine("Weekend"); break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day"); break;
                default:
                    Console.WriteLine("Error"); break;
            }
        }
    }
}
